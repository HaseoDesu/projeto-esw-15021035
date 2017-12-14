namespace project_sw.Models {
    public class Aluno {
        public long AlunoId {
            get {
                return AlunoId;
            }
            set {
                if (value < 0) return;
                AlunoId = value;
            }
        }
        public virtual int CC{get;set;}
    }
}