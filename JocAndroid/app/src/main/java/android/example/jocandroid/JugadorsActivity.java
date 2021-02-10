package android.example.jocandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.RadioButton;
import android.widget.Spinner;
import android.widget.Toast;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class JugadorsActivity extends AppCompatActivity {

    private static String name;
    public static int idusuari;
    public static String nomadmin;

    public static final int TEXT_REQUEST = 1;

    ListView lv;
    Spinner spper;

    Repositori rep;

    RadioButton rbnomjug;
    RadioButton rbidusu;
    RadioButton rbtot;
    RadioButton rbidpers;
    EditText ettext;
    ImageView imgjugard;
    ImageView imgjugarm;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_jugadors);

        Intent intent = getIntent();

        idusuari = intent.getIntExtra("idusuari", 0);
        nomadmin = intent.getStringExtra("nom");

        Retrofit retrofit = new Retrofit.Builder()
                .baseUrl("http://10.0.2.2:44300/api/")
                .addConverterFactory(GsonConverterFactory.create())
                .build();

        rep = retrofit.create(Repositori.class);

        lv = (ListView) findViewById(R.id.listjug);
        rbnomjug = (RadioButton) findViewById(R.id.rbnomj);
        rbidusu = (RadioButton) findViewById(R.id.rbidusu);
        rbtot = (RadioButton) findViewById(R.id.rbtot);
        rbidpers = (RadioButton) findViewById(R.id.rbidpers);
        ettext = (EditText) findViewById(R.id.ettext);
        spper = (Spinner) findViewById(R.id.sppersonatge);
        imgjugard = (ImageView) findViewById(R.id.imgvjugard);
        imgjugarm = (ImageView) findViewById(R.id.imgvjugarm);

        llistaspinner();

        llista();

        //aquest mètode fa que al fer clic a un objecte de la llista es modifiqui la imatge
        //        // per la que té aquell jugador.
        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {

            @Override
            public void onItemClick(AdapterView<?> arg0, View arg1, int position, long arg3) {

                try {
                    jugador j = (jugador) lv.getItemAtPosition(position);

                    int imatgearmadurajug = JugadorsActivity.this.getResources().getIdentifier(
                            "drawable" +
                                    "/armadura" + j.id_armadura,
                            null, JugadorsActivity.this.getPackageName());

                    imgjugard.setImageResource(imatgearmadurajug);

                    int imatgearmajug = JugadorsActivity.this.getResources().getIdentifier(
                            "drawable" +
                                    "/arma" + j.id_arma,
                            null, JugadorsActivity.this.getPackageName());

                    imgjugarm.setImageResource(imatgearmajug);
                } catch (Exception e) {
                    Log.i("JugadorsActivity", e.toString());
                }
            }
        });

    }

    public void enrere(View view) {
        Intent intent = new Intent(this, MenuPrincipal.class);
        intent.putExtra("idusuari", idusuari);
        intent.putExtra("nom", nomadmin);

        startActivityForResult(intent, TEXT_REQUEST);
    }

    public void cercajugador(View view) {
        //serveix per filtrar els jugadors mitjançant els diferents radio button
        if (rbnomjug.isChecked() && ettext.getText().length() > 0) { //
            llistajugadornom();
        } else if (rbidusu.isChecked()) {
            llistajugausu();
        } else if (rbidpers.isChecked()) {
            llsitajugadorpersonatge();
        } else if (rbtot.isChecked()) {
            llista();
        } else {
            Toast.makeText(JugadorsActivity.this, "Selecciona un radio button per cercar", Toast.LENGTH_SHORT).show();
        }
    }

    private void llistaspinner() {
        // obte tots els personatges i els posa al spinner
        Call<List<personatge>> call = rep.getPersonatges();

        call.enqueue(new Callback<List<personatge>>() {
            @Override
            public void onResponse(Call<List<personatge>> call, Response<List<personatge>> response) {

                List<personatge> mk = response.body();

                try {

                    if (mk != null) {
                        List<personatge> perslist = response.body();
                        ArrayAdapter<personatge> adapter = new ArrayAdapter<>(JugadorsActivity.this, android.R.layout.simple_list_item_1, perslist);
                        spper.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("JugadorsActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<personatge>> call, Throwable t) {
                Toast.makeText(JugadorsActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void llista() {
        //mostra tots els jugadors
        Call<List<jugador>> call = rep.getJugadors();

        call.enqueue(new Callback<List<jugador>>() {
            @Override
            public void onResponse(Call<List<jugador>> call, Response<List<jugador>> response) {

                List<jugador> mk = response.body();

                try {

                    if (mk != null) {
                        List<jugador> jugalist = response.body();
                        ArrayAdapter<jugador> adapter = new ArrayAdapter<>(JugadorsActivity.this, android.R.layout.simple_list_item_1, jugalist);
                        lv.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("JugadorsActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<jugador>> call, Throwable t) {
                Toast.makeText(JugadorsActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void llsitajugadorpersonatge() {
        //mostra tots els jugadors que tinguin el mateix personatge
        int id = (int) spper.getSelectedItemId();

        Call<List<jugador>> call = rep.getJugadorPersonatge(id + 1);

        call.enqueue(new Callback<List<jugador>>() {
            @Override
            public void onResponse(Call<List<jugador>> call, Response<List<jugador>> response) {

                List<jugador> mk = response.body();

                try {

                    if (mk != null) {
                        List<jugador> jugalist = response.body();
                        ArrayAdapter<jugador> adapter = new ArrayAdapter<>(JugadorsActivity.this, android.R.layout.simple_list_item_1, jugalist);
                        lv.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("JugadorsActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<jugador>> call, Throwable t) {
                Toast.makeText(JugadorsActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void llistajugausu() {
        //llista tots els jugadors que tingui aquell usuari
        Call<List<jugador>> call = rep.getJugadorsUsuari(idusuari);

        call.enqueue(new Callback<List<jugador>>() {
            @Override
            public void onResponse(Call<List<jugador>> call, Response<List<jugador>> response) {

                List<jugador> mk = response.body();

                try {

                    if (mk != null) {
                        List<jugador> jugalist = response.body();
                        ArrayAdapter<jugador> adapter = new ArrayAdapter<>(JugadorsActivity.this, android.R.layout.simple_list_item_1, jugalist);
                        lv.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("JugadorsActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<jugador>> call, Throwable t) {
                Toast.makeText(JugadorsActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void llistajugadornom() {
        //llista tots els jugadors que continguin el nom indicat
        Call<List<jugador>> call = rep.getJugadorName(ettext.getText().toString());

        call.enqueue(new Callback<List<jugador>>() {
            @Override
            public void onResponse(Call<List<jugador>> call, Response<List<jugador>> response) {

                List<jugador> mk = response.body();

                try {

                    if (mk != null) {
                        List<jugador> jugalist = response.body();
                        ArrayAdapter<jugador> adapter = new ArrayAdapter<>(JugadorsActivity.this, android.R.layout.simple_list_item_1, jugalist);
                        lv.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("JugadorsActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<jugador>> call, Throwable t) {
                Toast.makeText(JugadorsActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }
}
