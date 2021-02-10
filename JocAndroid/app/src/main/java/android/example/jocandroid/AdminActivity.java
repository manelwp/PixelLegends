package android.example.jocandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class AdminActivity extends AppCompatActivity {

    public static int idusuari;
    public static String nomadmin;
    public static Boolean tejugador = false;
    ArrayList<usuari> llistausuaris;

    ListView lv;
    EditText etnum;
    AlertDialog.Builder ad;

    Repositori rep;

    public static final int TEXT_REQUEST = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_admin);

        Retrofit retrofit = new Retrofit.Builder()
                .baseUrl("http://10.0.2.2:44300/api/")
                .addConverterFactory(GsonConverterFactory.create())
                .build();

        rep = retrofit.create(Repositori.class);

        Intent intent = getIntent();

        idusuari = intent.getIntExtra("idusuari", 0);
        nomadmin = intent.getStringExtra("nom");

        lv = (ListView) findViewById(R.id.listusu);
        etnum = (EditText) findViewById(R.id.etnumid);
        ad = new AlertDialog.Builder(this);
        llistausuaris = new ArrayList<usuari>();

        llistausu();
    }

    public void enrere(View view) {
        Intent intent = new Intent(this, MenuPrincipal.class);
        intent.putExtra("idusuari", idusuari);
        intent.putExtra("nom", nomadmin);

        startActivityForResult(intent, TEXT_REQUEST);
    }

    public void elimina(View view) {
        //comprova si el número de id introduït coincideix amb els usuaris que hi ha a la base de
        // dades.
        String nombre = etnum.getText().toString();
        int n = 0;
        boolean existeix = false;

        try {
            n = Integer.parseInt(nombre);
        } catch (Exception e) {
        }

        try {
            for (usuari u : llistausuaris) {
                if (u.getId() == n) {
                    existeix = true;
                }
            }
        } catch (Exception e) {
        }

        if (existeix && n != idusuari) {
            ad.setTitle("Epa");
            ad.setMessage("¿Esborrar ?");
            ad.setCancelable(false);
            ad.setPositiveButton("Confirmar", new DialogInterface.OnClickListener() {
                public void onClick(DialogInterface dialogo1, int id) {
                    aceptar();
                }
            });
            ad.setNegativeButton("Cancelar", new DialogInterface.OnClickListener() {
                public void onClick(DialogInterface dialogo1, int id) {

                }
            });
            ad.show();
        } else if (existeix && n == idusuari) {
            Toast.makeText(AdminActivity.this, "No pots borrar-te", Toast.LENGTH_SHORT).show();
        } else if (n == 0) {
            Toast.makeText(AdminActivity.this, "Introdueix algun número per eliminar", Toast.LENGTH_SHORT).show();
        } else if (!existeix && n != 0) {
            Toast.makeText(AdminActivity.this, "No existeix cap usuari amb aquesta id",
                    Toast.LENGTH_SHORT).show();
        }
        llistausu();
    }

    public void aceptar() {
        //comprova si el usuari té jugadors i els borra
        comprovajugador();

        //llista tots els usuaris
        llistausu();
    }

    private void llistausu() {
        //llista tots els usuaris
        Call<List<usuari>> call = rep.getUsuaris();

        call.enqueue(new Callback<List<usuari>>() {
            @Override
            public void onResponse(Call<List<usuari>> call, Response<List<usuari>> response) {

                List<usuari> mk = response.body();

                try {

                    if (mk != null) {
                        List<usuari> usulist = response.body();
                        ArrayAdapter<usuari> adapter = new ArrayAdapter<>(AdminActivity.this, android.R.layout.simple_list_item_1, usulist);
                        lv.setAdapter(adapter);
                        for (usuari u : usulist) {
                            llistausuaris.add(u);
                        }
                    }

                } catch (Exception e) {
                    Log.e("AdminActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<usuari>> call, Throwable t) {
                Toast.makeText(AdminActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });

    }

    private void comprovajugador() {
        //comprova si el usuari té jugadors en cas afirmatiu esborra els jugadors, en negatiu
        // borra directament el usuari.
        Call<List<jugador>> call =
                rep.getJugadorsUsuari(Integer.parseInt(etnum.getText().toString()));

        call.enqueue(new Callback<List<jugador>>() {
            @Override
            public void onResponse(Call<List<jugador>> call, Response<List<jugador>> response) {

                List<jugador> mk = response.body();

                try {
                    if (mk.size() > 0) {
                        esborrajugadorsusuari();
                    } else {
                        esborrausuari();
                    }
                } catch (Exception e) {
                }
            }

            @Override
            public void onFailure(Call<List<jugador>> call, Throwable t) {
                Toast.makeText(AdminActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void esborrajugadorsusuari() {
        //esborra tots els jugadors del usuari i continuament el usuari.
        Call<jugador> call = rep.deleteJugadorsUsuari(Integer.parseInt(etnum.getText().toString()));

        call.enqueue(new Callback<jugador>() {
            @Override
            public void onResponse(Call<jugador> call, Response<jugador> response) {

                if (response.isSuccessful()) {
                    Log.i("be", "funciona");
                    try {
                        esborrausuari();
                    } catch (Exception e) {
                        Log.i("AdminActivity", e.toString());
                    }
                } else {
                    Log.i("AdminActivity", "Error al borrar jugadors.");
                }
            }

            @Override
            public void onFailure(Call<jugador> call, Throwable t) {
                Toast.makeText(AdminActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void esborrausuari() {
        //esborra el usuari indicat
        Call<usuari> call = rep.deleteUsuariId(Integer.parseInt(etnum.getText().toString()));

        call.enqueue(new Callback<usuari>() {
            @Override
            public void onResponse(Call<usuari> call, Response<usuari> response) {

                if (response.isSuccessful()) {
                    Toast.makeText(AdminActivity.this, "Eliminat", Toast.LENGTH_SHORT).show();
                    Log.i("be", "funciona");
                    for (usuari u : llistausuaris) {
                        if (u.getId() == Integer.parseInt(etnum.getText().toString())) {
                            llistausuaris.remove(u);
                        }
                    }
                } else {
                    Toast.makeText(AdminActivity.this, "No Eliminat", Toast.LENGTH_SHORT).show();
                }
            }

            @Override
            public void onFailure(Call<usuari> call, Throwable t) {
                Toast.makeText(AdminActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });

        llistausu();
    }
}
