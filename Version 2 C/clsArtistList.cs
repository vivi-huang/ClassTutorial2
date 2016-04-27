using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Version_2_C
{
    [Serializable()]
    public class clsArtistList : SortedDictionary<string, clsArtist>
    {
        private const string _FileName = "gallery1.dat";

        //public void EditArtist(string prKey)
        //{
        //    clsArtist lcArtist;
        //    lcArtist = this[prKey];
        //    if (lcArtist != null)
        //        lcArtist.EditDetails();
        //    else
        //        throw new Exception("Sorry no artist by this name");
        //}

        //public void NewArtist()
        //{
        //    clsArtist lcArtist = new clsArtist(this);
        //    if (lcArtist.Name != "")
        //        Add(lcArtist.Name, lcArtist);
        //}

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsArtist lcArtist in Values)
            {
                lcTotal += lcArtist.TotalValue;
            }
            return lcTotal;
        }

        public static clsArtistList RetrieveArtistList()
        {
            clsArtistList lcArtistList;
            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Open);
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcArtistList = (clsArtistList)lcFormatter.Deserialize(lcFileStream);
                lcFileStream.Close();
            }
            catch (Exception ex)
            {
                lcArtistList = new clsArtistList();
                throw new Exception("File Retrieve Error: " + ex.Message);
            }
            return lcArtistList;
        }

        public void Save()
        {
            System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Create);
            BinaryFormatter lcFormatter = new BinaryFormatter();
            lcFormatter.Serialize(lcFileStream, this);
            lcFileStream.Close();
        }
    }
}
