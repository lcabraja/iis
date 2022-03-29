package hr.lcabraja.iis.exercise04.task01;

import hr.lcabraja.iis.exercise04.task01.models.AdresaType;
import hr.lcabraja.iis.exercise04.task01.models.ImenikType;
import hr.lcabraja.iis.exercise04.task01.models.ObjectFactory;
import hr.lcabraja.iis.exercise04.task01.models.OsobaType;
import org.w3c.dom.Node;

import javax.xml.bind.Binder;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import java.io.File;
import java.io.IOException;
import java.math.BigInteger;

public class Main {
    public static void main(String[] args) {
        ObjectFactory of = new ObjectFactory();

        AdresaType adresa = of.createAdresaType();
        adresa.setMjesto("Zagreb");
        adresa.setKucniBroj("242");
        adresa.setPostanskiBroj(BigInteger.valueOf(10000));
        adresa.setUlica("Ilica");

        OsobaType osoba = of.createOsobaType();
        osoba.setAdresa(adresa);
        osoba.setEmail("lcabraja@racunarstvo.hr");
        osoba.setIme("Luka");
        osoba.setPrezime("Čabraja");
        osoba.setKategorija("Kul");
        osoba.setOib("12345678901");
        osoba.setTelefon("0999999999");

        ImenikType imenik = of.createImenikType();
        imenik.getOsoba().add(osoba);
        imenik.getOsoba().add(osoba);
        imenik.getOsoba().add(osoba);
        imenik.getOsoba().add(osoba);

        try {
            JAXBContext jaxbContext = JAXBContext.newInstance(ImenikType.class);
            Marshaller marshaller = jaxbContext.createMarshaller();
            marshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
            marshaller.marshal(imenik, new File("/Users/doss/source/repos/iis/exercise-04/task01.xml"));
            marshaller.marshal(imenik, System.out);
        } catch (JAXBException e) {
            e.printStackTrace();
        }
    }
}
