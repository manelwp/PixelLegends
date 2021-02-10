package android.example.jocandroid;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.DELETE;
import retrofit2.http.GET;
import retrofit2.http.POST;
import retrofit2.http.Path;

public interface Repositori {

    //USUARI
    @POST("usuari")
    Call<usuari> insertUsuari(@Body usuari u);

    @GET("usuarin/{nom}")
    Call<usuari> getUsuariName(@Path("nom") String nom);

    @GET("usuarisnom/{nom}")
    Call<List<usuari>> getUsuarisNom(@Path("nom") String nom);

    @GET("usuaris")
    Call<List<usuari>> getUsuaris();

    @DELETE("usuarid/{id}")
    Call<usuari> deleteUsuariId(@Path("id") int id);

    //PERSONATGE
    @GET("personatges")
    Call<List<personatge>> getPersonatges();

    @GET("personatgen/{nom}")
    Call<personatge> getPersonatgeName(@Path("nom") String nom);

    @GET("personatgenom/{nom}")
    Call<List<personatge>> getPersonatgesNom(@Path("nom") String nom);

    @GET("personatge/{id}")
    Call<personatge> getPersonatgeID(@Path("id") int id);

    //MONSTRE
    @GET("monstres")
    Call<List<monstre>> getMonstres();

    @GET("monstren/{nom}")
    Call<monstre> getMonstreName(@Path("nom") String nom);

    @GET("monstresnom/{nom}")
    Call<List<monstre>> getMonstresNom(@Path("nom") String nom);

    @GET("monstre/{id}")
    Call<monstre> getMonstreID(@Path("id") int id);

    //ARMA
    @GET("armes")
    Call<List<arma>> getArmes();

    @GET("arman/{nom}")
    Call<arma> getArmaName(@Path("nom") String nom);

    @GET("armesnom/{nom}")
    Call<List<arma>> getArmesNom(@Path("nom") String nom);

    @GET("armespersonatge/{id_personatge}")
    Call<List<arma>> getArmesPersonatge(@Path("id_personatge") int id_personatge);

    @GET("arma/{id}")
    Call<arma> getArmaID(@Path("id") int id);

    //ARMADURA
    @GET("armadures")
    Call<List<armadura>> getArmadures();

    @GET("armaduran/{nom}")
    Call<armadura> getArmaduraName(@Path("nom") String nom);

    @GET("armaduresnom/{nom}")
    Call<List<armadura>> getArmaduresNom(@Path("nom") String nom);

    @GET("armadurespersonatge/{id_personatge}")
    Call<List<armadura>> getArmaduresPersonatge(@Path("id_personatge") int id_personatge);

    @GET("armadura/{id}")
    Call<armadura> getArmaduraID(@Path("id") int id);

    //JUGADOR
    @GET("jugadors")
    Call<List<jugador>> getJugadors();

    @GET("jugadornom/{nom}")
    Call<List<jugador>> getJugadorName(@Path("nom") String nom);

    @GET("jugadorusu/{id_usuari}")
    Call<List<jugador>> getJugadorsUsuari(@Path("id_usuari") int id_usuari);

    @GET("jugadorpers/{id_personatge}")
    Call<List<jugador>> getJugadorPersonatge(@Path("id_personatge") int id_personatge);

    @GET("jugador/{id}")
    Call<jugador> getJugadorID(@Path("id") int id);

    @GET("jugadorusu/{id}")
    Call<jugador> getJugadorUsuariID(@Path("id") int id);

    @DELETE("jugadorsusuari/{id_usuari}")
    Call<jugador> deleteJugadorsUsuari(@Path("id_usuari") int id_usuari);
}
