1. Name and surname where 'oib' starts with '0'
```xquery
for $item in /imenik/osoba
where starts-with($item/@oib, "0")
return ($item/ime,$item/prezime)
```

2. Street and place where post number is greater than 30
```xquery
for $item in /imenik/osoba
where $item/adresa/postanskiBroj>30
return ($item/adresa/ulica,$item/adresa/mjesto)
```

3. Email where surname starts with 'R'
```xquery
for $item in /imenik/osoba
where starts-with($item/prezime, "R")
return $item/email
```


4. Surname where place is 'Zagreb'
```xquery
for $item in /imenik/osoba
where $item/adresa/mjesto="Zagreb"
return $item/prezime
```