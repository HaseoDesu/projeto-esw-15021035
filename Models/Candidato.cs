using System;
namespace project_sw.Models {
    public class Candidato: User {
        public String nome {
            get {
                return nome;
            }
            set {
                if (value.Length > 125 || value.Trim().Length < 1) return;
                nome = value;
            }
        }

        public String morada {
            get;
            set;
        }

        public int niff {
            get;
            set;
        }

        public DateTime dataNascimento {
            get;
            set;
        }

        public bool partilhar {
            get;
            set;
        }

    }
}