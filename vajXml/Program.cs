using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;



namespace vajXml
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream(@"F:\Nova mapa\proo1\vajXml\vajXml\računi2.xml", FileMode.Open);
            //XmlSerializer a = new XmlSerializer(typeof(AGROMET));
            //AGROMET x = new AGROMET();
            //x = (AGROMET)a.Deserialize(fs);
            //Console.WriteLine(x.Location.LocationName);
            //foreach (AGROMETDATA y in x.DATA)
            //{
            //    Console.WriteLine(y.Date.ToShortDateString() + " " + y.Temp2);
            //}

            /////////////////////////////////////////////////////////////////////////////
            //1.)najprej filestream, tudi če je v projektu ima datoteka svoj path:path od projekta

            FileStream fs = new FileStream(@"C:\Users\miran\Desktop\računi2.xml", FileMode.Open);

            //2.)potem serializer, typeof je vedno tisti od naslova xml dokumenta
            //na osnovi dokumenta narediš tudi razred in kopiraš xml dokument in ga 
            //prilepiš: Edit->Paste Special -> Paste xml as Classes v ta isti
            //na novo ustvarjen razred 
            XmlSerializer a = new XmlSerializer(typeof(IzdaniRacunEnostavni));

            //3.)narediš nov izvod maloprej ustvarjenega razreda:
            IzdaniRacunEnostavni x = new IzdaniRacunEnostavni();

            //4.)Deserializiraš: svojemu novemu izvodu razreda IzdaniRacunEnostavni 
            //z imenom x pripišeš izvod razreda xmlserializer , ki si mu dal ime a
            //in njegovo metodo Serialize, ki potrebuje še parameter ki je , pot do 
            //mape, ki naj jo deserializira, kar smo spravili v spremenljivki fs
            //ko smo deklarirali nov izvod razreda filestrem. Obvezno moraš še
            //castat x v objekt tipa IzdaniRacunEnostavni, kakršen je a;
            
            x = (IzdaniRacunEnostavni)a.Deserialize(fs);
            Console.WriteLine(x.Racun.PovzetekZneskovRacuna);

            //5.izpis:y je tvoja kljuka, x pa izpeljan deserializiran izvod razreda
            foreach (var y in x.Racun.PostavkeRacuna)
            {
                Console.WriteLine(y.OpisiArtiklov.OpisArtikla.OpisArtikla1 + y.ZneskiPostavke.ZnesekPostavke);
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            //Prevzem
            //najprej filestram:
             FileStream tok = new FileStream(@"C:\Users\miran\Documents\Informatika\C#\programiranje2\vajXml\vajXml\Prevzem2.xml", FileMode.Open);

            //potem serializer
            XmlSerializer serializator = new XmlSerializer(typeof(vsipodatki));

            //izdelamo nov izvod našega razreda vsipodatki
            vsipodatki js_sm_izvod_razreda_vsi_podatki = new vsipodatki();

            //deserializiramo
            js_sm_izvod_razreda_vsi_podatki = (vsipodatki)serializator.Deserialize(tok);

            // Console.WriteLine(izvod);

            foreach(var y in js_sm_izvod_razreda_vsi_podatki.prevzem)
            {
                Console.WriteLine(y.Kolicina + y.letnik + y.sladkor);
            }

            //gremo za vajo še enkrate AGROMET
            //1.) najprej filestream
            FileStream tok1 = new FileStream(@"C:\Users\Miran\Downloads\AGROMET",FileMode.Open);

            //2.) potem serializer za  AGROMET
            XmlSerializer serijalizator = new XmlSerializer(typeof(AGROMET));

            //3.)nov izvod razreda AGROMET, tudi ustvarit ga je treba, dal mu bom ime še_en_račun
            AGROMET danko = new AGROMET();

            //4.)deserializacija, ne pozabi na metodo, ki naj jo izvede tvoj serializator
            //v kolikor mu ne kličeš nobene metode on tam sedi brez dela
            danko = (AGROMET)serijalizator.Deserialize(tok1);

            foreach(var m in danko.DATA)
            {
                Console.WriteLine(m.Humidity2+m.Temp2_Max);//samo ponuja vse postavke
            }

            








            Console.ReadLine();
           // MQTT, Moskito


        } 
    }
}
