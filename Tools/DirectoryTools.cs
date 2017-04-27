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
        /// <summary>
        /// Initiates transfer from solution directory to target directory.
        /// </summary>
        /// <param name="SolutionDirectory">Source</param>
        /// <param name="TargetDirectory">Destination</param>
        /// <param name="Exemptions">Include Transfer Date Threshold</param>
        /// 
        public void PerformTransfer(string SolutionDirectory, string TargetDirectory)
        {
            StreamReader reader;

            using (Process p = new Process())
            {
                p.StartInfo.FileName = "xcopy";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.Arguments = "\"" + SolutionDirectory + "\"" + " " + "\"" + TargetDirectory + "\"" + @"/s /y /I /c ";
                p.Start();

                long processedFiles = Convert.ToInt64(ProcessedFiles.Text);

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
                                    processedFiles++;
                                    ProcessedFiles.Text = processedFiles.ToString();

                                    if (!result.Contains("copied"))
                                    {
                                        FileTransfers.AppendText(result + "\n");
                                        FileTransfers.SelectionStart = FileTransfers.Text.Length;
                                        FileTransfers.ScrollToCaret();
                                    }
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
            try
            {
                foreach (string file in Directory.GetFiles(folder))
                {
                    tracker = file;
                    fileAction(file);
                }

                foreach (string subDirectory in Directory.GetDirectories(folder))
                {
                    CalculateProfileSizes(subDirectory, fileAction);
                }
            }
            catch
            {
                if(Properties.Settings.Default.ShowErrors)
                {

                  FileTransfers.Invoke((Action) delegate
                    {
                        FileTransfers.AppendText("Access Denied: " + tracker + "\n\n");
                        FileTransfers.SelectionStart = FileTransfers.Text.Length;
                        FileTransfers.ScrollToCaret();
                    });
                }
                File.AppendAllText("config\\errorlog.txt", "Access Denied: " + tracker + Environment.NewLine);
            }
        }
    }
}
