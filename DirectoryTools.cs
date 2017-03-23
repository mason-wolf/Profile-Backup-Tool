using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileBackupTool
{
    class DirectoryTools
    {
        public long totalSize = 0;
        public long previousSize = 0;
        public long copySize = 0;
        Label ProfileSizes;
        Label ProcessedFiles;

        RichTextBox FileTransfers;

        public DirectoryTools(Label ProfileSizeContainer, RichTextBox FileTransferContainer, Label ProcessedFilesContainer)
        {
            ProfileSizes = ProfileSizeContainer;
            FileTransfers = FileTransferContainer;
            ProcessedFiles = ProcessedFilesContainer;
        }

        static readonly string[] SizeSuffixes = {
            "bytes",
            "KB",
            "MB",
            "GB",
            "TB"
        };

        // convert bytes to megabytes, kilobytes, etc.
        static string SizeSuffix(Int64 value)
        {
            if (value < 0)
            {
                return "-" + SizeSuffix(-value);
            }

            if (value == 0)
            {
                return "0.0 bytes";
            }

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            if (Math.Round(adjustedSize, 1) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }

            return string.Format("{0:n" + 1 + "} {1}",
                adjustedSize,
                SizeSuffixes[mag]);
        }

        public void ProcessDirectorySizes(string path)
        {
            try
            {
                FileInfo info = new FileInfo(@path);
                totalSize += info.Length;
                ProfileSizes.Invoke((Action)delegate
                {
                    ProfileSizes.Text = SizeSuffix(totalSize);
                });
            }
            catch
            {

            }
        }

        public void PerformTransfer(string SolutionDirectory, string TargetDirectory)
        {
            StreamReader reader;
            int processedFiles = 0;

            using (Process p = new Process())
            {
                p.StartInfo.FileName = "xcopy";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardInput = true;
                string profileExemptionDate = "/d:01-01-2016";
                string exclusionList = "/EXCLUDE:config\\exclusions.txt";

                // If CopyAll option is enabled, the exclusion list will not be read.

                if(Properties.Settings.Default.CopyAll == true)
                {
                    p.StartInfo.Arguments = "\"" + SolutionDirectory + "\"" + " " + "\"" + TargetDirectory + "\"" + @"/s /y /I /c "  + profileExemptionDate;
                }
                else
                {
                    p.StartInfo.Arguments = "\"" + SolutionDirectory + "\"" + " " + "\"" + TargetDirectory + "\"" + @"/s /y /I /c " + exclusionList + profileExemptionDate;
                }

                p.Start();

                try
                {
                    using (reader = p.StandardOutput)
                    {
                        while (reader != null)
                        {
                            string result = reader.ReadLine();

                            FileTransfers.Invoke((Action)delegate
                            {
                                if (result != null)
                                {
                                    FileTransfers.AppendText(result + "\n");
                                    FileTransfers.SelectionStart = FileTransfers.Text.Length;
                                    FileTransfers.ScrollToCaret();
                                    processedFiles++;
                                    ProcessedFiles.Text = processedFiles.ToString();
                                }
                                else
                                {
                                    reader.Close();
                                }
                            });
                        }
                    }
                }
                catch 
                {

                }
                p.Close();
                p.Dispose();
            }
        }

        public string tracker;

        public void CalculateProfileSizes(string folder, Action<string> fileAction)
        {
            foreach (string file in Directory.GetFiles(folder))
            {
                tracker = file;
                fileAction(file);
            }

            foreach (string subDirectory in Directory.GetDirectories(folder))
            {
                try
                {
                   CalculateProfileSizes(subDirectory, fileAction);
                }
                catch(UnauthorizedAccessException)
                {
                    //    MessageBox.Show("Access denied: " + tracker);

                    File.AppendAllText("config\\errorlog.txt", "Access Denied: " + tracker + Environment.NewLine);

                    if (Properties.Settings.Default.ShowErrors)
                    {
                        FileTransfers.Invoke((Action)delegate
                        {
                            FileTransfers.AppendText("Access Denied: " + tracker + "\n\n");
                            FileTransfers.SelectionStart = FileTransfers.Text.Length;
                            FileTransfers.ScrollToCaret();
                        });
                    }

                }
                finally
                {

                }
            }
        }
    }
}
