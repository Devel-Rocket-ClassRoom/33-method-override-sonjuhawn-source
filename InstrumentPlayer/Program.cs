using System;
using System.Net.NetworkInformation;
using System.Xml.Linq;

// README.md를 읽고 코드를 작성하세요.


Instrument[] instruments = new Instrument[3];
instruments[0] = new Piano("피아노");
instruments[1] = new Piano("기타");
instruments[2] = new Piano("드럼");

Console.WriteLine("=== 악기 연주회 ===");
instruments[0].Tune();
instruments[0].Play();
Console.WriteLine();
instruments[1].Tune();
instruments[1].Play();
Console.WriteLine();

instruments[2].Tune();
instruments[2].Play();
Console.WriteLine();


