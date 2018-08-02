 
namespace Navistar.DataContext
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class ConnectionsConfig
    { 
        //Connecciones directas en el appsettings 
        //DATABASES
        public string NavimexVentasDB{ get; set; }
        public string DataMartDB { get; set; }      

        //Parametros para Mastercon   
        public string APP_NAME { get; set; }
    }
}
