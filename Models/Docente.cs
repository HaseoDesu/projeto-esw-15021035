namespace project_sw.Models {
    public class Docente: Candidato {
        public long docenteId {
            get {
                return docenteId;
            }
            set {
                if (value < 0) return;
                docenteId = value;
            }
        }
    }
}