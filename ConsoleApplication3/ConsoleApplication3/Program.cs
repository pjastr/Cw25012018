using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wycieczka w = new WycieczkaZag();
            //w.UstawDni(10);
            //w.UstawStawkeDzienna(100);
            //Console.WriteLine(w.ObliczCene());

            try
            {

                WycieczkaKraj wk = new WycieczkaKraj();
                Wycieczka w = wk;
                WycieczkaZag wz = (WycieczkaZag) w;
                wz.UstawDni(5);
                wz.UstawStawkeDzienna(50);
                Console.WriteLine(wz.ObliczCene());

            }
            catch (StackOverflowException soExp) {
                Console.WriteLine("stack exp");
            }
            catch (InvalidCastException iExp) {
                Console.WriteLine("cast exp");
            }
            catch (SystemException sExp){
                Console.WriteLine("system exp");
            }


        }
    }

    public class Wycieczka
    {
        int iloscDni;
        float stawkaZaDzien;
        float cena;

        public void UstawDni(int dni)
        {
            iloscDni = dni;
            ObliczCene();
        }
        public void UstawStawkeDzienna(float stawka)
        {
            stawkaZaDzien = stawka;
            ObliczCene();
        }
        public virtual float ObliczCene()
        {
            this.cena = iloscDni * stawkaZaDzien;
            return this.cena;
        }

        public float GetCena()
        {
            return cena;
        }

        public int GetIloscDni()
        {
            return iloscDni;
        }

        public float GetStawkaZaDzien()
        {
            return stawkaZaDzien;
        }
    }

    public class WycieczkaZag : Wycieczka
    {
        float podatekTurystycznyDzien =
        0.05f;
        float oplataStala = 50f;
        public override float ObliczCene()
        {
            return GetCena() + oplataStala + GetIloscDni() * GetStawkaZaDzien() * podatekTurystycznyDzien;
        }
    }

    public class WycieczkaKraj : Wycieczka
    {
        public WycieczkaKraj()
        {
        }
    }

}
