package android.example.jocandroid;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class arma {

    @SerializedName("id")
    @Expose
    public int id;
    @SerializedName("nom")
    @Expose
    public String nom;
    @SerializedName("dany")
    @Expose
    public double dany;
    @SerializedName("dany_especial")
    @Expose
    public double dany_especial;
    @SerializedName("id_personatge")
    @Expose
    public int id_personatge;

    public arma(int id, String nom, double dany, double dany_especial, int id_personatge) {
        this.id = id;
        this.nom = nom;
        this.dany = dany;
        this.dany_especial = dany_especial;
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

    public double getDany() {
        return dany;
    }

    public void setDany(double dany) {
        this.dany = dany;
    }

    public double getDany_especial() {
        return dany_especial;
    }

    public void setDany_especial(double dany_especial) {
        this.dany_especial = dany_especial;
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
                ", Nom=" + nom +
                ", Dany=" + dany +
                ", Dany especial=" + dany_especial +
                ", Id personatge=" + id_personatge;
    }
}
