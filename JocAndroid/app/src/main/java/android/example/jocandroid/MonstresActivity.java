package android.example.jocandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.RadioButton;
import android.widget.Toast;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class MonstresActivity extends AppCompatActivity {

    public static int idusuari;
    public static String nomadmin;

    ListView lv;
    EditText etfiltre;
    RadioButton rbtot;
    RadioButton rbnom;

    public static final int TEXT_REQUEST = 1;
    Repositori rep;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_monstres);

        Retrofit retrofit = new Retrofit.Builder()
                .baseUrl("http://10.0.2.2:44300/api/")
                .addConverterFactory(GsonConverterFactory.create())
                .build();

        rep = retrofit.create(Repositori.class);

        Intent intent = getIntent();

        idusuari = intent.getIntExtra("idusuari", 0);
        nomadmin = intent.getStringExtra("nom");

        lv = (ListView) findViewById(R.id.listmonstre);
        etfiltre = (EditText) findViewById(R.id.etfiltre);
        rbtot = (RadioButton) findViewById(R.id.rbtot);
        rbnom = (RadioButton) findViewById(R.id.rbnom);

        llista();
    }

    private void llista() {
        //llista tots els monstres
        Call<List<monstre>> call = rep.getMonstres();

        call.enqueue(new Callback<List<monstre>>() {
            @Override
            public void onResponse(Call<List<monstre>> call, Response<List<monstre>> response) {

                List<monstre> mk = response.body();

                try {

                    if (mk != null) {
                        List<monstre> monslist = response.body();
                        ArrayAdapter<monstre> adapter = new ArrayAdapter<>(MonstresActivity.this, android.R.layout.simple_list_item_1, monslist);
                        lv.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("MonstresActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<monstre>> call, Throwable t) {
                Toast.makeText(MonstresActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
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
        //serveix per filtrar els diferents monstres mitjançant els diferents radio button
        if (rbtot.isChecked()) {
            llista();
        } else if (rbnom.isChecked() && etfiltre.getText().length() > 0) {
            llistanom();
        } else {
            Toast.makeText(MonstresActivity.this, "Selecciona un radio button per cercar", Toast.LENGTH_SHORT).show();
        }
    }

    private void llistanom() {
        //llista tots els monstres que continguin el nom indicat
        Call<List<monstre>> call = rep.getMonstresNom(etfiltre.getText().toString());

        call.enqueue(new Callback<List<monstre>>() {
            @Override
            public void onResponse(Call<List<monstre>> call, Response<List<monstre>> response) {

                List<monstre> mk = response.body();

                try {

                    if (mk != null) {
                        List<monstre> monslist = response.body();
                        ArrayAdapter<monstre> adapter = new ArrayAdapter<>(MonstresActivity.this, android.R.layout.simple_list_item_1, monslist);
                        lv.setAdapter(adapter);
                    }

                } catch (Exception e) {
                    Log.e("MonstresActivity", e.toString());
                }
            }

            @Override
            public void onFailure(Call<List<monstre>> call, Throwable t) {
                Toast.makeText(MonstresActivity.this, "Error amb l'API", Toast.LENGTH_SHORT).show();
            }
        });
    }
}
