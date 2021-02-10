package android.example.jocandroid;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.res.ResourcesCompat;

import android.content.Context;
import android.content.Intent;
import android.content.res.Resources;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.RadioButton;
import android.widget.Toast;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class PersonatgesActivity extends AppCompatActivity {

    ListView lw;
    EditText etfiltre;
    RadioButton rbtot;
    RadioButton rbnom;
    ImageView iv;

    public static int idusuari;
    public static String nomadmin;

    public static final int TEXT_REQUEST = 1;
    Repositori rep;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_personatges);

        Retrofit retrofit = new Retrofit.Builder()
                .baseUrl("http://10.0.2.2:44300/api/")
                .addConverterFactory(GsonConverterFactory.create())
                .build();

        rep = retrofit.create(Repositori.class);

        Intent intent = getIntent();

        idusuari = intent.getIntExtra("idusuari", 0);
        nomadmin = intent.getStringExtra("nom");

        lw = (ListView) findViewById(R.id.listpers);
        etfiltre = (EditText) findViewById(R.id.etfiltre);
        rbtot = (RadioButton) findViewById(R.id.rbtot);
        rbnom = (RadioButton) findViewById(R.id.rbnom);
        iv = (ImageView) findViewById(R.id.imgvpers);

        llista();

        //aquest mètode fa que al fer clic a un objecte de la llista es modifiqui la imatge
        // per la que té aquell personatge.
        lw.setOnItemClickListener(new AdapterView.OnItemClickListener() {

            @Override
            public void onItemClick(AdapterView<?> arg0, View arg1, int position, long arg3) {

                try {
                    personatge p = (personatge) lw.getItemAtPosition(position);

                    int res_imagen = PersonatgesActivity.this.getResources().getIdentifier("drawable" +
                                    "/personatge" + p.id,
                            null, PersonatgesActivity.this.getPackageName());

                    iv.setImageResource(res_imagen);
                } catch (Exception e) {
                    Log.i("PersonatgesActivity", e.toString());
                }
            }
        });
    }

    private void llista() {
        //llista a tots els personatges
        Call<List<personatge>> call = rep.getPersonatges();

        call.enqueue(new Callback<List<personatge>>() {
            @Override
            public void onResponse(Call<List<personatge>> call, Response<List<personatge>> response) {

                List<personatge> mk = response.body();

                try {

                    if (mk != null) {
                        List<personatge> perlist = response.body();
                        ArrayAdapter<personatge> adapter = new ArrayAdapter<>(PersonatgesActivity.this, android.R.layout.simple_list_item_1, perlist);
                        lw.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("PersonatgesActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<personatge>> call, Throwable t) {
                Toast.makeText(PersonatgesActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
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
        //serveix per filtrar els personatges mitjançant els diferents radio button
        if (rbtot.isChecked()) {
            llista();
        } else if (rbnom.isChecked() && etfiltre.getText().length() > 0) {
            llistanom();
        } else {
            Toast.makeText(PersonatgesActivity.this, "Selecciona un radio button per cercar", Toast.LENGTH_SHORT).show();
        }
    }

    private void llistanom() {
        //llista tots els personatges que continguin el nom indicat
        Call<List<personatge>> call = rep.getPersonatgesNom(etfiltre.getText().toString());

        call.enqueue(new Callback<List<personatge>>() {
            @Override
            public void onResponse(Call<List<personatge>> call, Response<List<personatge>> response) {

                List<personatge> mk = response.body();

                try {

                    if (mk != null) {
                        List<personatge> perslist = response.body();
                        ArrayAdapter<personatge> adapter = new ArrayAdapter<>(PersonatgesActivity.this, android.R.layout.simple_list_item_1, perslist);
                        lw.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("PersonatgesActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<personatge>> call, Throwable t) {
                Toast.makeText(PersonatgesActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }
}
