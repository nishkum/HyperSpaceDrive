using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.IsolatedStorage;
using System.IO;


namespace hyperSpaceDrive
{

    public static class Level
    {
        public static int curlevel=1;
        public static int hl1=282;
        public static int hl2=0;
        public static int score=0;
        public static bool isNewScoreHigh=false ;
       
        
        public static void loadfn()
        {
            IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForApplication();
            if (store.FileExists("test.txt")) // Check if file exists
            {
                IsolatedStorageFileStream save = new IsolatedStorageFileStream("test.txt", FileMode.Open, store);
                BinaryReader reader = new BinaryReader(save);
                string mystring = reader.ReadString();
                hl1 = (int)reader.ReadSingle();
                reader.Close();
            }
        }

        public static void strfn()
        {
            IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForApplication(); // grab the storage
            FileStream stream = store.OpenFile("test.txt", FileMode.Create); // Open a file in Create mode
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write("SCORE : ");
            writer.Write(hl1);
            writer.Close();
        }
    }
}
