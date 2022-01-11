using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace LAB1_JS
{
    public class DbManager
    {
        public static void INSERT(DataClasses1DataContext dc, int id, string nazwavar, int uservar = 0, int rozvar = 0, int polvar = 0)
        {
            // tworzymy nowy obiekt klasy ProductCategory 
            dataTable prod = new dataTable();           
            prod.Id = id;
            prod.nazwa = nazwavar;
            prod.data = DateTime.Now;
            prod.godzina = DateTime.Now.TimeOfDay;
            prod.usr = uservar;
            prod.roz = rozvar;
            prod.pol = polvar;
            // Wywołujemy metode InsertOnSubmit oraz zaspisujemy dane
            dc.dataTable.InsertOnSubmit(prod);
            dc.SubmitChanges();
            // zwracamy ostatni rekord w celu sprawdzenia powyższego kodu           
            // Wyświetlamy ten element w konsoli

            
        }
        public static void DELETE(DataClasses1DataContext dc, string nazwavar)
        {
            // w pierwszej kolejności zwracamy dane, które chcemy usuanąć
            var data = from p in dc.dataTable
                       where p.nazwa.Contains(nazwavar)
                       select p;
            // kasujemy zwrócone dane z naszej tabeli
            dc.dataTable.DeleteAllOnSubmit(data);
            // zapisujemy zmiany
            dc.SubmitChanges();

        }
        public static void UPDATE(DataClasses1DataContext dc, string nazwavar, int uservar, int rozvar, int polvar)
        {
            // dokonamy update wszystkich rekordow w ktorych nazwa produktu zaiwiera "Tube"
            var update = from p in dc.dataTable
                         where p.nazwa.Contains(nazwavar)
                         select p;
            // Zmieniamy nazwę na inną, przy czym nazwa musi być unikalna
            // wg. projektu tej konkretnej bazy danych
            int i = 0;
            foreach (var item in update)
            {
                item.usr = uservar;
                item.roz = rozvar;
                item.pol = polvar;
                
            }
            // Zapisujemy zmiany            
            dc.SubmitChanges();           
        }
        public static bool SELECT(DataClasses1DataContext dc, string nazwavar)
        {
            // zwracamy dane z tabeli Product gdzie cena jest większa niż 300
            var data = from p in dc.dataTable
                       where p.nazwa == nazwavar
                       select p;
            foreach (var item in data)
            {
                // Wypisujemy podstawowe informacje
                Debug.WriteLine(item.nazwa);
            }
            if (data.Count()==0)
            {
                Debug.WriteLine("true");
                return true;
            }
            else
            {
                Debug.WriteLine("false");
                return false;
            }
        }
        public static int SELECTmaxID(DataClasses1DataContext dc)
        {
            // zwracamy dane z tabeli Product gdzie cena jest większa niż 300
            var data = from p in dc.dataTable                      
                       select p.Id;
            int maxID = data.Max();
            return maxID;
        }

        public static List<string> SELECTrow(DataClasses1DataContext dc, string nazwavar)
        {
            List<string> list = new List<string>();
            var data = (from p in dc.dataTable
                       where p.nazwa == nazwavar
                       select p);
             var item = data.First();
            list.Add(item.nazwa);
            list.Add((item.data).ToString());
            list.Add((item.godzina).ToString());
            list.Add(item.usr.ToString());
            list.Add(item.roz.ToString());
            list.Add(item.pol.ToString());
            return list;
        }
        public static void UPDATEusr(DataClasses1DataContext dc, string nazwavar)
        {
            var update = (from p in dc.dataTable
                          where p.nazwa.Contains(nazwavar)
                          select p).First();
            update.usr = update.usr++;
            Debug.WriteLine("Updatuje");
            dc.SubmitChanges();
        }

        public static void UPDATEroz(DataClasses1DataContext dc, string nazwavar)
        {
            var update = (from p in dc.dataTable
                          where p.nazwa == nazwavar
                          select p).SingleOrDefault();
            Debug.WriteLine(update.nazwa);
            update.roz = update.roz++;
            Debug.WriteLine("Updatuje rozmiar");
            dc.SubmitChanges();
        }
        public static void UPDATEpol(DataClasses1DataContext dc, string nazwavar)
        {
            var update = (from p in dc.dataTable
                          where p.nazwa.Contains(nazwavar)
                          select p).First();
            update.pol = update.pol++;
            Debug.WriteLine("Updatuje");
            dc.SubmitChanges();           
        }
    }

    
}