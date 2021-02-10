package android.example.jocandroid;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class jugador {

    @SerializedName("id")
    @Expose
    public int id;
    @SerializedName("nom")
    @Expose
    public String nom;
    @SerializedName("nivell")
    @Expose
    public int nivell;
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
    @SerializedName("id_usuari")
    @Expose
    public int id_usuari;
    @SerializedName("id_personatge")
    @Expose
    public int id_personatge;
    @SerializedName("id_armadura")
    @Expose
    public int id_armadura;
    @SerializedName("id_arma")
    @Expose
    public int id_arma;

    public jugador(int id, String nom, int nivell, double vida, double atac, double atac_especial, double defensa, double defensa_especial, int id_usuari, int id_personatge, int id_armadura, int id_arma) {
        this.id = id;
        this.nom = nom;
        this.nivell = nivell;
        this.vida = vida;
        this.atac = atac;
        this.atac_especial = atac_especial;
        this.defensa = defensa;
        this.defensa_especial = defensa_especial;
        this.id_usuari = id_usuari;
        this.id_personatge = id_personatge;
        this.id_armadura = id_armadura;
        this.id_arma = id_arma;
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

    public int getNivell() {
        return nivell;
    }

    public void setNivell(int nivell) {
        this.nivell = nivell;
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

    public int getId_usuari() {
        return id_usuari;
    }

    public void setId_usuari(int id_usuari) {
        this.id_usuari = id_usuari;
    }

    public int getId_personatge() {
        return id_personatge;
    }

    public void setId_personatge(int id_personatge) {
        this.id_personatge = id_personatge;
    }

    public int getId_armadura() {
        return id_armadura;
    }

    public void setId_armadura(int id_armadura) {
        this.id_armadura = id_armadura;
    }

    public int getId_arma() {
        return id_arma;
    }

    public void setId_arma(int id_arma) {
        this.id_arma = id_arma;
    }

    @Override
    public String toString() {
        return "Nom=" + nom +
                ", Nivell=" + nivell +
                ", Vida=" + vida +
                ", Atac=" + atac +
                ", Atac especial=" + atac_especial +
                ", Defensa=" + defensa +
                ", Defensa especial=" + defensa_especial +
                ", Id usuari=" + id_usuari +
                ", Id personatge=" + id_personatge +
                ", Id armadura=" + id_armadura +
                ", Id arma=" + id_arma;
    }
}
