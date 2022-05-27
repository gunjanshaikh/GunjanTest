using System;
using System.Diagnostics;
using System.IO;

namespace TestCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* DriveInfo[] allDrives = DriveInfo.GetDrives();
             int count = 0;
             foreach (DriveInfo d in allDrives)
             {
                 if (d.IsReady && d.DriveType == DriveType.NoRootDirectory)
                {
                    Console.WriteLine( "Directory:  "+d.RootDirectory);
               }
                 count++;
             }
             List<string> data = new List<string>();

             // var loggedOnUsers = new Dictionary<string, DateTime>();
             string data_prev = null;
            try
             {
                 ManagementScope scope = new ManagementScope(String.Format(@"\\{0}\root\cimv2", "."));
                SelectQuery sessionQuery = new SelectQuery("Win32_LogonSession");

                 using (ManagementObjectSearcher sessionSearcher = new ManagementObjectSearcher(scope, sessionQuery))
                 using (ManagementObjectCollection sessionMOs = sessionSearcher.Get())
                 {
                     int xount = 0;
                     foreach (var sessionMO in sessionMOs)
                     {
                            var logonId = (string)sessionMO.Properties["LogonId"].Value;
                             var startTimeString = (string)sessionMO.Properties["StartTime"].Value;
                         var type = (UInt32)sessionMO.Properties["LogonType"].Value;
                         var startTime = DateTime.ParseExact(startTimeString.Substring(0, 21), "yyyyMMddHHmmss.ffffff", System.Globalization.CultureInfo.InvariantCulture);

                             WqlObjectQuery userQuery = new WqlObjectQuery(@"ASSOCIATORS OF {Win32_LogonSession.LogonId='" + logonId + @"'} WHERE AssocClass=Win32_LoggedOnUser");

                             using (var userSearcher = new ManagementObjectSearcher(scope, userQuery))
                             using (var userMOs = userSearcher.Get())
                             {
                                 var username = userMOs.OfType<ManagementObject>().Select(u => (string)u.Properties["Name"].Value).FirstOrDefault();
                                 if (username!=null && data_prev!=username)
                                 {
                                 data_prev = username;
                                 data.Insert(xount, "ID: " + logonId + "   User name: " + username + "   Time stamp: " + startTime.ToString() + "   Logon Type: " + type.ToString());
                                 Console.WriteLine(data[xount]);
                                 xount++;
                             }


                             }
                         }
                    //}

                 }
             }
             catch (Exception ref1)
             {
                 Console.WriteLine("Exception for WmI" + ref1.Message);
             }
             Console.WriteLine("BluEvent Service Log: Error while executing user command1");
            for (; ; )
            {
                using (Process p = new Process())
                {
                    Console.WriteLine("BluEvent Service Log: Error while executing user command2");
                    try
                    {
                        Console.WriteLine("BluEvent Service Log: Error while executing user command");

                        ProcessStartInfo userproc = new ProcessStartInfo();
                        Console.WriteLine("BluEvent Service Log: Error while executing user command");
                        userproc.WorkingDirectory = @"C:\Windows\System32";
                        userproc.Arguments = "127.0.0.1";
                        userproc.FileName = @"C:\Windows\System32\PING.exe";
                        userproc.UseShellExecute = false;
                        userproc.WindowStyle = ProcessWindowStyle.Normal;
                        userproc.RedirectStandardInput = true;
                        userproc.RedirectStandardOutput = true;
                        userproc.RedirectStandardError = true;
                        p.StartInfo = userproc;
                        p.Start();
                        Console.WriteLine("BluEvent Service Log: Error while executing user command" + userproc.FileName);
                        
                        StreamReader stdOutput = p.StandardOutput;
                        StreamReader stdError = p.StandardError;
                        string content_user = stdOutput.ReadToEnd() + stdError.ReadToEnd();
                        Console.WriteLine("BluEvent Service Log: Error while executing user command");

                        Trace.WriteLine(content_user);
                        string exitStatus = p.ExitCode.ToString();
                        if (exitStatus != "0")
                        {
                            Console.WriteLine("BluEvent Service Log: Error while executing user command" + userproc.FileName);
                        }
                        else
                        {
                            Console.WriteLine("BluEvent Service Log: Successfully executing user command" + userproc.FileName);
                        }
                        Console.WriteLine("BluEvent Service Log: Error while executing user command");

                          string[] rows = Regex.Split(content_user, "\r\n");
                          Console.WriteLine("BluEvent Service Log: Error while executing user command");

                          foreach (string row in rows)
                          {
                              Console.WriteLine("BluEvent Service Log: Users logged on to system currently" + row);
                          }
                    }
                    catch (Exception data)
                    {
                        Console.WriteLine("BluEvent Service Log: Users logged on to system currently Exception..." + data.Message);
                    }
                }

            }*/// Console.ReadLine();
            for (int x=0;x<6;x++)
            {
                Console.WriteLine("Test data.......................");
            }
        }
    }
}