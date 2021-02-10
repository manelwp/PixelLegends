package android.example.jocandroid;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class usuari {

    @SerializedName("id")
    @Expose
    private int id;

    @SerializedName("nom")
    @Expose
    private String nom;

    @SerializedName("contrasenya")
    @Expose
    private String contrasenya;

    @SerializedName("secret")
    @Expose
    private byte secret;

    public usuari() {
    }

    public usuari(int id, String nom, String contrasenya, byte secret) {
        this.id = id;
        this.nom = nom;
        this.contrasenya = contrasenya;
        this.secret = secret;
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

    public String getContrasenya() {
        return contrasenya;
    }

    public void setContrasenya(String contrasenya) {
        this.contrasenya = contrasenya;
    }

    public byte getSecret() {
        return secret;
    }

    public void setSecret(byte secret) {
        this.secret = secret;
    }

    @Override
    public String toString() {
        return "Id=" + id +
                ", Nom=" + nom +
                ", Contrasenya=" + contrasenya +
                ", Secret=" + secret;
    }
}
