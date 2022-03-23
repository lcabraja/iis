## Task 01

1. All people
```xquery
/imenik/osoba
```

2. All people named Ana
```xquery
/imenik/osoba[ime="Ana"]
```

3. All people whos postcode is '10000' in alphabetical order
```xquery
for $item in /imenik/osoba
where $item/adresa/postanskiBroj=10000
order by $item/ime
return $item/ime
```

4. All data represented as an HTML list
```xquery
<ul>
{
for $item in /imenik/osoba
return <li>{$item}</li>
}
</ul>
```

5. All names and surnames without an 'oib' attribute
```xquery
for $item in /imenik/osoba
where empty($item/@oib)
return ($item/ime, $item/prezime)
```

6. All names and surnames whose 'oib' attribute is not 11 characters long
```xquery
for $item in /imenik/osoba
where string-length($item/@oib)!=11
return ($item/ime, $item/prezime)
```

7. All phone numbers that aren't marked as 'Privatni'
```xquery
for $item in /imenik/osoba
where $item/kategorija != "Privatni"
return $item/telefon
```

8. All email addresses of those whose surnames end in 'ić'
```xquery
for $item in /imenik/osoba
where ends-with($item/prezime, "ić")
return $item/email
```
