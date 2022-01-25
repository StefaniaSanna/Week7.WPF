using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.WPF.DemoEventi.Pub_Sub
{
    public class Subscriber
    {
        public string SubscriberName { get; set; }
        public Subscriber(string name)
        {
            SubscriberName = name;

        }
        //Metodo di sottoscrizione e cancelazione dall'evento
        public void Subscribe(Publisher p) //quando mi iscrivo deve partire onPublish
        {
            p.OnPublish += OnNotificationReceived;

        }
        public void UnSubscribe(Publisher p)
        {
            p.OnPublish -= OnNotificationReceived;
        }

        //Metodo per gestire la ricezione della notifica
        protected virtual void OnNotificationReceived(Publisher p, Notification n)
        {
            Console.WriteLine($"Hi {SubscriberName} \n {n}");

        } //ha la stessa firma del delegato descrito in publisher
    }
}
