using System;

namespace Deneme27_ExcpHndlng
{
    class Metrik
    {
        private int mMetre;
        private int mSantim;
        public Metrik(int metre, int santim)
        {
            if (santim > 99)
                throw new HataliMetrikIstisnasi(santim, "Yapıcı Metot");

            mMetre = metre;
            mSantim = santim;
        }
        public void DegerVer(int metre, int santim)
        {
            if (santim > 99)
                throw new HataliMetrikIstisnasi(santim, "DegerVer Metodu");
            mMetre = metre;
            mSantim = santim;
        }
        public int Metre
        {
            get;
            set;
        }
        public int Santim
        {
            get { return mSantim; }
            set
            {
                if (value > 99)
                throw new HataliMetrikIstisnasi(value, "Santim Özelliği");

                mSantim =value;
            }
        }
    }
    public class HataliMetrikIstisnasi : ApplicationException
    {
        private int mHataliSantim;
        private string mHataKayangi;
        public HataliMetrikIstisnasi(int mHataliSantim, string mHataKayangi)
        {
            this.mHataliSantim = mHataliSantim;
            this.mHataKayangi = mHataKayangi;
        }

        public int HataliSantim
        {
            get { return mHataliSantim; }
        }
        public string HataKaynagi
        {
            get { return mHataKayangi; }
        }

        public override string ToString()
        {
            string str1 = "Hata Kaynağı :" + mHataKayangi + ",";
            string str2 = "Hata degeri :" + mHataliSantim;
            return str1 + str2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("\nHello World...\n");

        }
    }
}
