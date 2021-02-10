package android.example.jocandroid;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class armadura {

    @SerializedName("id")
    @Expose
    public int id;
    @SerializedName("nom")
    @Expose
    public String nom;
    @SerializedName("defensa")
    @Expose
    public double defensa;
    @SerializedName("defensa_especial")
    @Expose
    public double defensa_especial;
    @SerializedName("id_personatge")
    @Expose
    public int id_personatge;

    public armadura(int id, String nom, double defensa, double defensa_especial, int id_personatge) {
        this.id = id;
        this.nom = nom;
        this.defensa = defensa;
        this.defensa_especial = defensa_especial;
        this.id_personatge = id_personatge;
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

    public int getId_personatge() {
        return id_personatge;
    }

    public void setId_personatge(int id_personatge) {
        this.id_personatge = id_personatge;
    }

    @Override
    public String toString() {
        return "Id=" + id +
                ", Nom='" + nom +
                ", Defensa=" + defensa +
                ", Defensa especial=" + defensa_especial +
                ", Id personatge=" + id_personatge;
    }
}
