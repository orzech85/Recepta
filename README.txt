05-02-2013

Zmienily sie troche zalozenia.

Program wymaga 2 dodatkowych plik�w do funkcjonowania:

1. plik o nazwie A1.csv - zawiera baze lek�w
struktura tego pliku to:

G��wny sk�adnik leku;Nazwa leku;Odp�atno��

2. plik o nazwie Recepta.png - jest to plik graficzny z wzorem recepty - potrzebny do wydruku

------------------------------------------------------------------------------------------------------------------
Projekt RECEPTA

baza pacjent�w
pola
	PESEL
	Imie
	Nazwisko
	Adres


baza lek�w
pola:
	ID
	Nazwa


baza recept
	ID
	Data
	PESEL
	
pacjent:
80111100112;Jan;Kowalski;ul.B�otna nr zachlapany, W�chock
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
