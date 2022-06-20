using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Archivos
{
    public class IOArchivos<T>
        where T : new()
    {
        private string path;

        public IOArchivos(string path)
        {
            this.path = path;
        }


        public void GuardarTxtFechaActual( string texto)
        {
            try
            {
               
                using (StreamWriter archivo = new StreamWriter(this.path + $" {DateTime.Now.ToString("dd")}-{DateTime.Now.ToString("MM")}.txt"))
                {
                    archivo.WriteLine(texto);
                }
            }
            catch(Exception)
            {
                throw;
            }

        }


        public void GuardarXml(T objeto)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StreamWriter archivo = new StreamWriter(this.path))
            {
                serializer.Serialize(archivo, objeto);
            }
        }

        public T CargarXml()
        {
            T obj = new T();

            if (File.Exists(this.path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (StreamReader archivo = new StreamReader(this.path ))
                {
                    obj = (T) serializer.Deserialize(archivo) ;
                }
                return obj;
            }
            throw new Exception("Error al cargar archivo");
        }

    }
}
