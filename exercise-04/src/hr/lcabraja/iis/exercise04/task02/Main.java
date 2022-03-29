package hr.lcabraja.iis.exercise04.task02;

import com.sun.jmx.remote.internal.Unmarshal;
import hr.lcabraja.iis.exercise04.task02.models.ObjectFactory;
import hr.lcabraja.iis.exercise04.task02.models.StudentType;
import hr.lcabraja.iis.exercise04.task02.models.StudentiType;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;
import java.io.File;

public class Main {
    public static void main(String[] args) {
        ObjectFactory of = new ObjectFactory();

        StudentType student = of.createStudentType();
        student.setIme("Ivan");
        student.setPrezime("Markić");
        student.setDolaznost(100);

        StudentiType studenti = of.createStudentiType();
        studenti.getStudent().add(student);

        try {
            JAXBContext jaxbContext = JAXBContext.newInstance(StudentiType.class);
            Marshaller marshaller = jaxbContext.createMarshaller();
            marshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
            marshaller.marshal(studenti, new File("/Users/doss/source/repos/iis/exercise-04/task02.xml"));
            marshaller.marshal(studenti, System.out);

            System.out.println("");

            Unmarshaller unmarshaller = jaxbContext.createUnmarshaller();
            Object unmarshal = unmarshaller.unmarshal(new File("/Users/doss/source/repos/iis/exercise-04/task02.xml"));
            System.out.println(unmarshal);
        } catch (JAXBException e) {
            e.printStackTrace();
        }
    }
}
