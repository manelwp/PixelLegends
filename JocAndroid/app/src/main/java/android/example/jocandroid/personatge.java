package android.example.jocandroid;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class personatge {

    @SerializedName("id")
    @Expose
    public int id;
    @SerializedName("nom")
    @Expose
    public String nom;
    @SerializedName("vida")
    @Expose
    public double vida;
    @SerializedName("atac")
    @Expose
    public double atac;
    @SerializedName("atac_especial")
    @Expose
    public double atac_especial;
    @SerializedName("defensa")
    @Expose
    public double defensa;
    @SerializedName("defensa_especial")
    @Expose
    public double defensa_especial;

    public personatge() {
    }

    public personatge(int id, String nom, double vida, double atac, double atac_especial, double defensa, double defensa_especial) {
        this.id = id;
        this.nom = nom;
        this.vida = vida;
        this.atac = atac;
        this.atac_especial = atac_especial;
        this.defensa = defensa;
        this.defensa_especial = defensa_especial;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public double getVida() {
        return vida;
    }

    public void setVida(double vida) {
        this.vida = vida;
    }

    public double getAtac() {
        return atac;
    }

    public void setAtac(double atac) {
        this.atac = atac;
    }

    public double getAtac_especial() {
        return atac_especial;
    }

    public void setAtac_especial(double atac_especial) {
        this.atac_especial = atac_especial;
    }

    public double getDefensa() {
        return defensa;
    }

    public void setDefensa(double defensa) {
        this.defensa = defensa;
    }

    public double getDefensa_especial() {
        return defensa_especial;
    }

    public void setDefensa_especial(double defensa_especial) {
        this.defensa_especial = defensa_especial;
    }

    @Override
    public String toString() {
        return "Id=" + id + "Nom=" + nom +
                ", Vida=" + vida +
                ", Atac=" + atac +
                ", Atac especial=" + atac_especial +
                ", Defensa=" + defensa +
                ", Defensa especial=" + defensa_especial;
    }
}
