package android.example.jocandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.InputType;
import android.util.Log;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class MainActivity extends AppCompatActivity {

    Repositori rep;

    TextView tvnom;
    TextView tvcontra;

    Boolean mosocu = false;

    public static final int TEXT_REQUEST = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        tvnom = (TextView) findViewById(R.id.etnom);
        tvcontra = (TextView) findViewById(R.id.etcontra);

        Retrofit retrofit = new Retrofit.Builder()
                .baseUrl("http://10.0.2.2:44300/api/")
                .addConverterFactory(GsonConverterFactory.create())
                .build();

        rep = retrofit.create(Repositori.class);
    }

    public void entra(View view) {
        //aquest mètode comprova si el nom i la contrasenya introduïts coincideixen amb la base
        // de dades, en cas afirmatiu es passa a la següent activity.
        final String nom, contrasenya;
        final int[] id = {0};

        nom = tvnom.getText().toString();

        contrasenya = getSha256Hash(tvcontra.getText().toString());

        Call<List<usuari>> call = rep.getUsuarisNom(nom);

        call.enqueue(new Callback<List<usuari>>() {
            @Override
            public void onResponse(Call<List<usuari>> call, Response<List<usuari>> response) {
                int n = 0;

                List<usuari> mk = response.body();

                try {

                    if (mk.size() > 0) {
                        for (usuari u : mk) {

                            if (u.getContrasenya().equals(contrasenya) && u.getNom().equals(nom)) {

                                id[0] = u.getId();
                                menu(id[0], nom);

                            } else if (u.getNom().equals(nom) && !u.getContrasenya().equals(contrasenya)) {
                                Toast.makeText(MainActivity.this, "Contrasenya incorrecta",
                                        Toast.LENGTH_SHORT).show();
                            } else {
                                n++;
                            }
                        }

                        if (n == mk.size()) {
                            Toast.makeText(MainActivity.this, "No existeix cap usuari amb aquest nom",
                                    Toast.LENGTH_SHORT).show();
                        }
                    } else {
                        Toast.makeText(MainActivity.this, "No existeix cap usuari amb aquest nom",
                                Toast.LENGTH_SHORT).show();
                    }
                } catch (Exception e) {
                    Log.e("MainActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<usuari>> call, Throwable t) {
                Toast.makeText(MainActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }

    public void menu(int id, String nom) {
        Intent intent = new Intent(this, MenuPrincipal.class);

        intent.putExtra("idusuari", id);

        intent.putExtra("nom", nom);

        startActivityForResult(intent, TEXT_REQUEST);
    }

    public static String getSha256Hash(String password) {
        //fa els hash per tal de comparar les contrasenyes
        try {
            MessageDigest digest = null;
            try {
                digest = MessageDigest.getInstance("SHA-256");
            } catch (NoSuchAlgorithmException e1) {
                e1.printStackTrace();
            }
            digest.reset();
            return bin2hex(digest.digest(password.getBytes()));
        } catch (Exception ignored) {
            return null;
        }
    }

    private static String bin2hex(byte[] data) {
        StringBuilder hex = new StringBuilder(data.length * 2);
        for (byte b : data)
            hex.append(String.format("%02x", b & 0xFF));
        return hex.toString();
    }

    public void comprovaexisteix(View view) {
        //comprova si el usuari introduït ja esta a la base de dades. En cas negatiu podràs
        // registrar el usuari, en positiu et dirà que ja hi ha un usuari amb aquest nom.
        final String nom;

        nom = tvnom.getText().toString();

        Call<List<usuari>> call = rep.getUsuarisNom(nom);

        call.enqueue(new Callback<List<usuari>>() {
            @Override
            public void onResponse(Call<List<usuari>> call, Response<List<usuari>> response) {
                int n = 0;

                List<usuari> mk = response.body();

                try {
                    if (mk.size() > 0) {

                        n = 0;
                        for (usuari u : mk) {

                            if (u.getNom().equalsIgnoreCase(nom)) {
                                Toast.makeText(MainActivity.this, "Ja existeix un usuari amb aquest nom", Toast.LENGTH_SHORT).show();
                            } else {
                                n++;
                            }
                        }
                        if (n == mk.size()) {
                            registra();
                        }
                    } else {
                        registra();
                    }

                } catch (Exception e) {
                    Log.e("MainActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<usuari>> call, Throwable t) {
                Toast.makeText(MainActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
                registra();
            }
        });
    }

    public void registra() {
        // aquest mètode insereix el usuari introduït als textbox anteriorment
        usuari u = new usuari();

        String contrasenya, nom;

        nom = tvnom.getText().toString();

        contrasenya = getSha256Hash(tvcontra.getText().toString());

        u.setNom(nom);
        u.setContrasenya(contrasenya);

        Call<usuari> call = rep.insertUsuari(u);

        call.enqueue(new Callback<usuari>() {
            @Override
            public void onResponse(Call<usuari> call, Response<usuari> response) {

                if (response.isSuccessful()) {
                    Toast.makeText(MainActivity.this, "Inserit", Toast.LENGTH_SHORT).show();
                    Log.i("be", "funciona");
                } else {
                    Toast.makeText(MainActivity.this, "No Inserit", Toast.LENGTH_SHORT).show();
                }
            }

            @Override
            public void onFailure(Call<usuari> call, Throwable t) {
                Toast.makeText(MainActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }
}