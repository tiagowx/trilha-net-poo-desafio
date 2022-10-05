namespace DesafioPOO.Utils{

  public class IMEI {
    public static string NovoIMEI (){
      string IMEI = "3562";

      for(int i = 0; IMEI.Length <= 15; i++){
        Random randon = new Random();
        IMEI += randon.Next(0, 9).ToString();
      }

      return IMEI;
    }
  }
}