using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.WPF.DemoEventi.Pub_Sub
{
    public class Publisher
    {
        public string PublisherName { get; set; }
        public Publisher(string publisherName)
        {
            PublisherName = publisherName;

        }
        //Dichiarazione evendo
        public event Notify OnPublish; //questo è un delegato, un metodo che deve essere eseguito in fase di pubblicazione dell'evento

        public delegate void Notify(Publisher p, Notification notification); //notification ha le informazioni da notificare
        //tutti quelli che si iscrivono all'evento devono averlo

        //metodo per pubblicare l'evento stesso
        public void Publish()
        {
            //se l'evento è scatenato(diverso da null) deve creare un oggetto di tipo notification
            if(OnPublish != null)
            {
                Notification notification = new Notification(DateTime.Now, $"Notifica da parte di {PublisherName}");
                OnPublish(this, notification);
            }
        }

    }
}
