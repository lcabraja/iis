
package hr.lcabraja.iis.exercise04.task01.models;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the hr.lcabraja.iis.exercise04.task01.models package. 
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

    private final static QName _Imenik_QNAME = new QName("", "imenik");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: hr.lcabraja.iis.exercise04.task01.models
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link ImenikType }
     * 
     */
    public ImenikType createImenikType() {
        return new ImenikType();
    }

    /**
     * Create an instance of {@link OsobaType }
     * 
     */
    public OsobaType createOsobaType() {
        return new OsobaType();
    }

    /**
     * Create an instance of {@link AdresaType }
     * 
     */
    public AdresaType createAdresaType() {
        return new AdresaType();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ImenikType }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "", name = "imenik")
    public JAXBElement<ImenikType> createImenik(ImenikType value) {
        return new JAXBElement<ImenikType>(_Imenik_QNAME, ImenikType.class, null, value);
    }

}
