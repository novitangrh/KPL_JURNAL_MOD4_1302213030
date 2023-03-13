// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

internal class KodeBuah
{
    private string[] buah = { 
        "Apel", "Aprikot", "Alpukat", "Pisang", "Paprika", "Blackberry", "Ceri", 
        "Kelapa", "Jagung","Kurma", "Durian", "Anggur", "Melon", "Semangka"
    };
    private string[] kode = { 
        "A00", "B00", "C00", "D00", "E00", "F00", "H00", 
        "I00", "J00", "K00", "L00", "M00", "N00", "O00" 
    };

    public string getKodeBuah(string fruit)
    {
        for(int i = 0; i < buah.Length; i++)
        {
            if (buah[i] == fruit)
            {
                return "Kode buah: " + kode[i];
            }
        }
        return "Buah tidak tesedia";
    }
}

public class PosisiKarakterGame
{

    private string[] PositionState = {"Berdiri", "Terbang", "Jongkok", "Tengkurap"};

    class TransitionState
    {
        public enum PositionState
        {
            Berdiri,
            Terbang,
            Jongkok,
            Tengkurap

        }

        public enum tombolState
        {
            TombolW,
            TombolS,
            TombolX,
        }


        public PositionState currentState = PositionState.Berdiri;

        public tombolState currentTombols;
        public PositionState PreviousState;
        public PositionState NextState;
        public TransitionState(tombolState currentTombols, PositionState PreviousState, PositionState NextState) {
            this.currentTombols = currentTombols;
            this.PreviousState = PreviousState;
            this.NextState = NextState;
        }

        public TransitionState[] ReturnTransitionArray()
        {
            TransitionState[] result =
            {
                new TransitionState(tombolState.TombolW, PositionState.Tengkurap, PositionState.Jongkok),
                new TransitionState(tombolState.TombolW, PositionState.Jongkok, PositionState.Berdiri),
                new TransitionState(tombolState.TombolS, PositionState.Berdiri, PositionState.Jongkok),
                new TransitionState(tombolState.TombolW, PositionState.Berdiri, PositionState.Terbang),
                new TransitionState(tombolState.TombolS, PositionState.Terbang, PositionState.Berdiri),
                new TransitionState(tombolState.TombolX, PositionState.Terbang, PositionState.Jongkok),
                new TransitionState(tombolState.TombolS, PositionState.Jongkok, PositionState.Tengkurap);
            }
            return 
        }
    }


class Program
{
    public static void Main(string[] agrs)
    {
        KodeBuah kode = new KodeBuah();
        Console.Write("Nama buah: ");
        string buah = Console.ReadLine();
        Console.WriteLine(kode.getKodeBuah(buah));
    }
}
