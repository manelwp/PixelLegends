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

public class ArmesActivity extends AppCompatActivity {


    public static int idusuari;
    public static String nomadmin;

    ListView lv;
    EditText etfiltre;
    RadioButton rbtot;
    RadioButton rbnom;
    RadioButton rbtipusper;
    Spinner spper;
    ImageView imgarma;

    public static final int TEXT_REQUEST = 1;
    Repositori rep;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_armes);

        Retrofit retrofit = new Retrofit.Builder()
                .baseUrl("http://10.0.2.2:44300/api/")
                .addConverterFactory(GsonConverterFactory.create())
                .build();

        rep = retrofit.create(Repositori.class);

        Intent intent = getIntent();

        idusuari = intent.getIntExtra("idusuari", 0);
        nomadmin = intent.getStringExtra("nom");

        lv = (ListView) findViewById(R.id.listarmes);
        etfiltre = (EditText) findViewById(R.id.etname);
        rbtot = (RadioButton) findViewById(R.id.rbtot);
        rbnom = (RadioButton) findViewById(R.id.rbnom);
        rbtipusper = (RadioButton) findViewById(R.id.rbtipusper);
        spper = (Spinner) findViewById(R.id.spnTipusPer);
        imgarma = (ImageView) findViewById(R.id.imgarma);

        llistaspinner();

        llista();

        //aquest mètode fa que al fer clic a un objecte de la llista es modifiqui la imatge
        //        // per la que té aquell jugador.
        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {

            @Override
            public void onItemClick(AdapterView<?> arg0, View arg1, int position, long arg3) {

                try {
                    arma a = (arma) lv.getItemAtPosition(position);

                    int armaimg = ArmesActivity.this.getResources().getIdentifier("drawable" +
                                    "/arma" + a.id,
                            null, ArmesActivity.this.getPackageName());

                    imgarma.setImageResource(armaimg);
                } catch (Exception e) {
                    Log.i("ArmesActivity", e.toString());
                }
            }
        });
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
                        ArrayAdapter<personatge> adapter = new ArrayAdapter<>(ArmesActivity.this, android.R.layout.simple_list_item_1, perslist);
                        spper.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("ArmesActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<personatge>> call, Throwable t) {
                Toast.makeText(ArmesActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void llista() {
        //llista totes les armes
        Call<List<arma>> call = rep.getArmes();

        call.enqueue(new Callback<List<arma>>() {
            @Override
            public void onResponse(Call<List<arma>> call, Response<List<arma>> response) {

                List<arma> mk = response.body();

                try {

                    if (mk != null) {
                        List<arma> armlist = response.body();
                        ArrayAdapter<arma> adapter = new ArrayAdapter<>(ArmesActivity.this, android.R.layout.simple_list_item_1, armlist);
                        lv.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("ArmesActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<arma>> call, Throwable t) {
                Toast.makeText(ArmesActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }

    public void enrere(View view) {
        Intent intent = new Intent(this, MenuPrincipal.class);
        intent.putExtra("idusuari", idusuari);
        intent.putExtra("nom", nomadmin);

        startActivityForResult(intent, TEXT_REQUEST);
    }

    public void botocerca(View view) {
        //serveix per filtrar les armes mitjançant els diferents radio button
        if (rbtot.isChecked()) {
            llista();
        } else if (rbnom.isChecked() && etfiltre.getText().length() > 0) {
            llistanom();
        } else if (rbtipusper.isChecked()) {
            llistaarmespersonatge();
        } else {
            Toast.makeText(ArmesActivity.this, "Selecciona un radio button per cercar", Toast.LENGTH_SHORT).show();
        }
    }

    private void llistanom() {
        //llista tots els jugadors que continguin el nom indicat
        Call<List<arma>> call = rep.getArmesNom(etfiltre.getText().toString());

        call.enqueue(new Callback<List<arma>>() {
            @Override
            public void onResponse(Call<List<arma>> call, Response<List<arma>> response) {

                List<arma> mk = response.body();

                try {

                    if (mk != null) {
                        List<arma> armalist = response.body();
                        ArrayAdapter<arma> adapter = new ArrayAdapter<>(ArmesActivity.this, android.R.layout.simple_list_item_1, armalist);
                        lv.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("ArmesActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<arma>> call, Throwable t) {
                Toast.makeText(ArmesActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void llistaarmespersonatge() {
        //llista totes les armes que tinguin un mateix personatge
        int id = (int) spper.getSelectedItemId();

        Call<List<arma>> call = rep.getArmesPersonatge(id + 1);

        call.enqueue(new Callback<List<arma>>() {
            @Override
            public void onResponse(Call<List<arma>> call, Response<List<arma>> response) {

                List<arma> mk = response.body();

                try {

                    if (mk != null) {
                        List<arma> armalist = response.body();
                        ArrayAdapter<arma> adapter = new ArrayAdapter<>(ArmesActivity.this, android.R.layout.simple_list_item_1, armalist);
                        lv.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("ArmesActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<arma>> call, Throwable t) {
                Toast.makeText(ArmesActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }
}
