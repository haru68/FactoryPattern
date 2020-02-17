using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    abstract class President
    {
        public abstract string slogan { get; }
    }

    class PresidentLREM : President
    {
        public override string slogan { get => "Lançons la Réunion Entre les Manchots"; }
    }

    class PresidentCentre : President
    {
        public override string slogan { get => "Bof bof"; }
    }

    class PresidentExtremeGauche : President
    {
         public override string slogan { get => "Cuicui les oiseaux, bzzz bzzz les zabeilles"; }
    }

    class PresidentEcolo : President
    {
         public override string slogan { get => "Tous à poil et on s'caresse"; }
    }

    class PresidentGauche : President
    {
         public override string slogan { get => "Rien pour vous"; }
    }

    class PresidentDroite : President
    {
         public override string slogan { get => "Lave plus blanc que blanc!"; }
    }

    class PresidentExtremeDroite : President
    {
         public override string slogan { get => "La règle des 3B : Blanche blonde bonne ou rien!"; }
    }

}
