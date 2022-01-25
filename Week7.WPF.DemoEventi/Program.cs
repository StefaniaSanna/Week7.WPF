// See https://aka.ms/new-console-template for more information
using Week7.WPF.DemoEventi.Pub_Sub;

Console.WriteLine("Hello, World!");
//Creazione dei publisher 
Publisher youtube = new Publisher("Youtube.com");
Publisher instagram = new Publisher("Instagram");

//creazione subscribers
Subscriber sub1 = new Subscriber("Antonia");
Subscriber sub2 = new Subscriber("Renata");
Subscriber sub3 = new Subscriber("Alessandra");

//non abbiamo ancora collegato, dobbiamo usare il metodo

sub1.Subscribe(youtube);
sub2.Subscribe(youtube);

sub3.Subscribe(instagram);
sub1.Subscribe(instagram);

youtube.Publish(); //questo publish viene svolto dal click in una applicazione wpf, noi li facciamo scatenare da eventi

Console.WriteLine("------------");

instagram.Publish();

Console.WriteLine("------------");


sub1.Subscribe(youtube);
youtube.Publish(); //a questo punto antonia non è più iscritta e non riceve la notifica




