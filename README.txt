05-02-2013

Zmienily sie troche zalozenia.

Program wymaga 2 dodatkowych plików do funkcjonowania:

1. plik o nazwie A1.csv - zawiera baze leków
struktura tego pliku to:

G³ówny sk³adnik leku;Nazwa leku;Odp³atnoœæ

2. plik o nazwie Recepta.png - jest to plik graficzny z wzorem recepty - potrzebny do wydruku

------------------------------------------------------------------------------------------------------------------
Projekt RECEPTA

baza pacjentów
pola
	PESEL
	Imie
	Nazwisko
	Adres


baza leków
pola:
	ID
	Nazwa


baza recept
	ID
	Data
	PESEL
	
pacjent:
80111100112;Jan;Kowalski;ul.B³otna nr zachlapany, W¹chock
82051200745;Krzysztof;Nowak;ul.Inna 12/34, 12-345 Inne miasto

leki:
1;Paracetamol 500mg
2;Gripex
3;Aspiryna 200mg
4;Flegamina

receptay:
1;19-01-2013;80111100112;1
1;19-01-2013;80111100112;3
2;20-01-2013;82051200745;2
2;20-01-2013;82051200745;4
3;19-01-2013;82051200745;1
