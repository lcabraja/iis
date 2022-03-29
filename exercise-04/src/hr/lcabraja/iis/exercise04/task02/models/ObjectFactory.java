
package hr.lcabraja.iis.exercise04.task02.models;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the hr.lcabraja.iis.exercise04.task02.models package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _Studenti_QNAME = new QName("", "studenti");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: hr.lcabraja.iis.exercise04.task02.models
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link StudentType }
     * 
     */
    public StudentType createStudentType() {
        return new StudentType();
    }

    /**
     * Create an instance of {@link StudentiType }
     * 
     */
    public StudentiType createStudentiType() {
        return new StudentiType();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Object }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "", name = "studenti")
    public JAXBElement<Object> createStudenti(Object value) {
        return new JAXBElement<Object>(_Studenti_QNAME, Object.class, null, value);
    }

}
