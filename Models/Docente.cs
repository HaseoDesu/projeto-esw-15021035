namespace project_sw.Models {
    public class Docente {
        public long docenteId {
            get {
                return docenteId;
            }
            set {
                if (value < 0) return;
                docenteId = value;
            }
        }
        
        public virtual int CC{get;set;}
    }
}