select * from ogrenci where bolumid in (Select id from bolum)

select  o.`AD`,o.`SOYAD`,b.`AD` 
from ogrenci o,bolum b
where o.bolumid=b.id

SELECT concat(o.`AD`," ",o.`SOYAD`) as adsoyad,d.`AD` as dersadi, d.`KREDI` as derskredi,od.`DERSALISTIPI` 
FROM ogrenciders od,ogrenci o,ders d
where od.`DERSID`=d.`ID` and od.`OGRENCI_ID`=o.`ID`

