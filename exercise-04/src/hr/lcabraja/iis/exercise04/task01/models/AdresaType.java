
package hr.lcabraja.iis.exercise04.task01.models;

import java.math.BigInteger;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for adresaType complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="adresaType">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="ulica" type="{http://www.w3.org/2001/XMLSchema}string"/>
 *         &lt;element name="kucniBroj" type="{http://www.w3.org/2001/XMLSchema}string"/>
 *         &lt;element name="mjesto" type="{http://www.w3.org/2001/XMLSchema}string"/>
 *         &lt;element name="postanskiBroj" type="{http://www.w3.org/2001/XMLSchema}integer"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "adresaType", propOrder = {
    "ulica",
    "kucniBroj",
    "mjesto",
    "postanskiBroj"
})
public class AdresaType {

    @XmlElement(required = true)
    protected String ulica;
    @XmlElement(required = true)
    protected String kucniBroj;
    @XmlElement(required = true)
    protected String mjesto;
    @XmlElement(required = true)
    protected BigInteger postanskiBroj;

    /**
     * Gets the value of the ulica property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getUlica() {
        return ulica;
    }

    /**
     * Sets the value of the ulica property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setUlica(String value) {
        this.ulica = value;
    }

    /**
     * Gets the value of the kucniBroj property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKucniBroj() {
        return kucniBroj;
    }

    /**
     * Sets the value of the kucniBroj property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKucniBroj(String value) {
        this.kucniBroj = value;
    }

    /**
     * Gets the value of the mjesto property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMjesto() {
        return mjesto;
    }

    /**
     * Sets the value of the mjesto property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMjesto(String value) {
        this.mjesto = value;
    }

    /**
     * Gets the value of the postanskiBroj property.
     * 
     * @return
     *     possible object is
     *     {@link BigInteger }
     *     
     */
    public BigInteger getPostanskiBroj() {
        return postanskiBroj;
    }

    /**
     * Sets the value of the postanskiBroj property.
     * 
     * @param value
     *     allowed object is
     *     {@link BigInteger }
     *     
     */
    public void setPostanskiBroj(BigInteger value) {
        this.postanskiBroj = value;
    }

}
