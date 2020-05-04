using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVetoresPousada {
    class Quarto {
        public string Nome { get; set; }
        public string Email { get; set; }

        public int QuartoEsc { get; set; }

        public Quarto() {

        }

        public Quarto(string nome, string email, int quarto) {

        }

        public override string ToString() {
            return "Estudante: " + Nome + "\nEmail: " + Email + "\nNumero do quarto: " + QuartoEsc;
        }
    }
}
