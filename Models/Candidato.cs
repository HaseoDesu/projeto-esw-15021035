using System;
using System.ComponentModel.DataAnnotations;

namespace project_sw.Models {
    public class Candidato{
        public String nome {
            get {
                return nome;
            }
            set {
                if (value.Length > 125 || value.Trim().Length    < 1) return;
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
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dataNascimento {
            get;
            set;
        }

        public bool partilhar {
            get;
            set;
        }

        public virtual int CC{get;set;}

    }
}