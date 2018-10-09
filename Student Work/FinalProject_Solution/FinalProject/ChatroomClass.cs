using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalProject
{
    public class ChatroomClass
    {
            //Properties
            public string userName;

            
            //default constructor
            public ChatroomClass()
            {

            }
     
            public static List <string> Reader()
            {
                String line;

            //Pass the file path and file name to the StreamReader constructor
             StreamReader sr = new StreamReader(@"S:\Students\Math\Student Work\Computer Science\Donnelly Final Project/ChatroomLog.txt");
            //StreamReader sr = new StreamReader("S:\\Students\\Math\\Student Work\\Computer Science\\Donnelly Final Project\\ChatroomLog.txt");

            //Read the first line of text
            line = sr.ReadLine();
                    //create array and counter
                    List<string> sendline = new List<string>();
                    // sendline.Add("");
                    int i = 0;

            //Continue to read until you reach end of file
            while (line != null)
                    {
                        //Read the next line
                        line = sr.ReadLine();
                        //read to array
                        sendline.Add(line);
                        //counter
                        i++;
                    }

                    //close the file
                    sr.Close();
                    //Console.ReadLine();
                    return sendline;
            }

        }
    }
