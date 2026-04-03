public class AccessModifiers{
	public static void Main(String[] args){
		//public access modifiers
	public int publicValue{
		public void PublicMethod(){
			Console.WriteLine("Public Method");
		}
	}
	//protected access modifiers
	protected int protectedValue{
		protected void ProtectedMethod(){
			Console.WriteLine("Protected Method");
		}	
	}
	//private access modifiers
	private int privateValue{
		private void PrivateMethod(){
			Console.WriteLine("Private Method");
		}
		public void AccessPrivate(){
		privateValue = 10;
		PrivateMethod();
		}
	}
	//internal access modifiers
	internal int internalValue{
		internal void InternalMethod(){
			Console.WriteLine("InternalMethod");
		}
		//protectedInternal and privateProtected Access Modifiers it differentiates java and csharp 
	}
	}
}