// See https://aka.ms/new-console-template for more information
using Composite;

Console.WriteLine("Hello, World!");

var piece = new Piece();
var piece1 = new Piece();
var piece2 = new Piece();
var cardboard = new Cardboard();
var cardboard1 = new Cardboard();
var cardboard2 = new Cardboard();

cardboard1.Add(piece);
cardboard2.Add(piece1);
cardboard.Add(cardboard1);
cardboard.Add(piece2);
Console.WriteLine(cardboard1.Operation());
Console.WriteLine(cardboard2.Operation());
Console.WriteLine(cardboard.Operation());