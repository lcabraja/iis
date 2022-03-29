
package hr.lcabraja.iis.exercise04.task02.models;

import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.annotation.*;


/**
 * <p>Java class for studentiType complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="studentiType">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="student" type="{}studentType" maxOccurs="unbounded"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "studentiType", propOrder = {
    "student"
})
@XmlRootElement
public class StudentiType {

    @XmlElement(required = true)
    protected List<StudentType> student;

    /**
     * Gets the value of the student property.
     * 
     * <p>
     * This accessor method returns a reference to the live list,
     * not a snapshot. Therefore any modification you make to the
     * returned list will be present inside the JAXB object.
     * This is why there is not a <CODE>set</CODE> method for the student property.
     * 
     * <p>
     * For example, to add a new item, do as follows:
     * <pre>
     *    getStudent().add(newItem);
     * </pre>
     * 
     * 
     * <p>
     * Objects of the following type(s) are allowed in the list
     * {@link StudentType }
     * 
     * 
     */
    public List<StudentType> getStudent() {
        if (student == null) {
            student = new ArrayList<StudentType>();
        }
        return this.student;
    }

}
