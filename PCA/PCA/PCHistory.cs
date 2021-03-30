namespace PCA
{
	internal class PCHistory
	{
		public PCHistory()
		{
			data = System.DateTime.Today.ToString();
			power = true;
		}
		public string data { get; set; }
		public bool power;
	}
}