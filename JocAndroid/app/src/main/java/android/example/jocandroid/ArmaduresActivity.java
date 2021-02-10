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

public class ArmaduresActivity extends AppCompatActivity {

    public static int idusuari;
    public static String nomadmin;

    ListView lv;
    EditText etfiltre;
    RadioButton rbtot;
    RadioButton rbnom;
    RadioButton rbtipuspers;
    Spinner spntipper;
    ImageView imgarmadura;

    Repositori rep;
    public static final int TEXT_REQUEST = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_armadures);

        Retrofit retrofit = new Retrofit.Builder()
                .baseUrl("http://10.0.2.2:44300/api/")
                .addConverterFactory(GsonConverterFactory.create())
                .build();

        rep = retrofit.create(Repositori.class);

        Intent intent = getIntent();

        idusuari = intent.getIntExtra("idusuari", 0);
        nomadmin = intent.getStringExtra("nom");

        lv = (ListView) findViewById(R.id.listarmadu);
        etfiltre = (EditText) findViewById(R.id.etfiltre);
        rbtot = (RadioButton) findViewById(R.id.rbtot);
        rbnom = (RadioButton) findViewById(R.id.rbnom);
        rbtipuspers = (RadioButton) findViewById(R.id.rbtipuspers);
        spntipper = (Spinner) findViewById(R.id.spntipuspers);
        imgarmadura = (ImageView) findViewById(R.id.imgarmadura);

        llistaspinner();

        llista();

        //aquest mètode fa que al fer clic a un objecte de la llista es modifiqui la imatge
        // per la que té aquell personatge.
        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {

            @Override
            public void onItemClick(AdapterView<?> arg0, View arg1, int position, long arg3) {

                try {
                    armadura ad = (armadura) lv.getItemAtPosition(position);

                    int armaduraimg = ArmaduresActivity.this.getResources().getIdentifier("drawable" +
                                    "/armadura" + ad.id,
                            null, ArmaduresActivity.this.getPackageName());

                    imgarmadura.setImageResource(armaduraimg);
                } catch (Exception e) {
                    Log.e("ArmaduresActivity", e.toString());
                }
            }
        });
    }

    private void llistaspinner() {
        //obte tots els personatges i els posa al spinner
        Call<List<personatge>> call = rep.getPersonatges();

        call.enqueue(new Callback<List<personatge>>() {
            @Override
            public void onResponse(Call<List<personatge>> call, Response<List<personatge>> response) {

                List<personatge> mk = response.body();

                try {

                    if (mk != null) {
                        List<personatge> perslist = response.body();
                        ArrayAdapter<personatge> adapter = new ArrayAdapter<>(ArmaduresActivity.this, android.R.layout.simple_list_item_1, perslist);
                        spntipper.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("ArmaduresActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<personatge>> call, Throwable t) {
                Toast.makeText(ArmaduresActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void llista() {
        //mostra totes les armadures
        Call<List<armadura>> call = rep.getArmadures();

        call.enqueue(new Callback<List<armadura>>() {
            @Override
            public void onResponse(Call<List<armadura>> call, Response<List<armadura>> response) {

                List<armadura> mk = response.body();

                try {

                    if (mk != null) {
                        List<armadura> armadlist = response.body();
                        ArrayAdapter<armadura> adapter = new ArrayAdapter<>(ArmaduresActivity.this, android.R.layout.simple_list_item_1, armadlist);
                        lv.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("ArmaduresActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<armadura>> call, Throwable t) {
                Toast.makeText(ArmaduresActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
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
        //serveix per filtrar els jugadors mitjançant els diferents radio button
        if (rbtot.isChecked()) {
            llista();
        } else if (rbnom.isChecked() && etfiltre.getText().length() > 0) {
            llistanom();
        } else if (rbtipuspers.isChecked()) {
            llistaarmadurespersonatge();
        } else {
            Toast.makeText(ArmaduresActivity.this, "Selecciona un radio button per cercar", Toast.LENGTH_SHORT).show();
        }
    }

    private void llistanom() {
        //llista totes les armadures que continguin el nom indicat
        Call<List<armadura>> call = rep.getArmaduresNom(etfiltre.getText().toString());

        call.enqueue(new Callback<List<armadura>>() {
            @Override
            public void onResponse(Call<List<armadura>> call, Response<List<armadura>> response) {

                List<armadura> mk = response.body();

                try {

                    if (mk != null) {
                        List<armadura> armdlist = response.body();
                        ArrayAdapter<armadura> adapter = new ArrayAdapter<>(ArmaduresActivity.this, android.R.layout.simple_list_item_1, armdlist);
                        lv.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("ArmaduresActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<armadura>> call, Throwable t) {
                Toast.makeText(ArmaduresActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void llistaarmadurespersonatge() {
        //mostra totes les armadures d-un mateix personatge
        int id = (int) spntipper.getSelectedItemId();

        Call<List<armadura>> call = rep.getArmaduresPersonatge(id + 1);

        call.enqueue(new Callback<List<armadura>>() {
            @Override
            public void onResponse(Call<List<armadura>> call, Response<List<armadura>> response) {

                List<armadura> mk = response.body();

                try {

                    if (mk != null) {
                        List<armadura> armadulist = response.body();
                        ArrayAdapter<armadura> adapter = new ArrayAdapter<>(ArmaduresActivity.this, android.R.layout.simple_list_item_1, armadulist);
                        lv.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("ArmaduresActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<armadura>> call, Throwable t) {
                Toast.makeText(ArmaduresActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }
}
