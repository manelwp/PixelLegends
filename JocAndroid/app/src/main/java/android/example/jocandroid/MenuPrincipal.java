package android.example.jocandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class MenuPrincipal extends AppCompatActivity {

    public static int idusuari;
    public static String nomadmin;

    Button btadmin;

    public static final int TEXT_REQUEST = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_principal);

        btadmin = (Button) findViewById(R.id.btnAdmin);

        Intent intent = getIntent();

        idusuari = intent.getIntExtra("idusuari", 0);
        nomadmin = intent.getStringExtra("nom");

        if (nomadmin.equalsIgnoreCase("admin")) {
            btadmin.setVisibility(View.VISIBLE);
        }
    }

    public void monsentra(View view) {
        Intent intent = new Intent(this, MonstresActivity.class);
        intent.putExtra("idusuari", idusuari);
        intent.putExtra("nom", nomadmin);

        startActivityForResult(intent, TEXT_REQUEST);
    }

    public void persentra(View view) {
        Intent intent = new Intent(this, PersonatgesActivity.class);
        intent.putExtra("idusuari", idusuari);
        intent.putExtra("nom", nomadmin);

        startActivityForResult(intent, TEXT_REQUEST);
    }

    public void armesentra(View view) {
        Intent intent = new Intent(this, ArmesActivity.class);
        intent.putExtra("idusuari", idusuari);
        intent.putExtra("nom", nomadmin);

        startActivityForResult(intent, TEXT_REQUEST);
    }

    public void armaduentra(View view) {
        Intent intent = new Intent(this, ArmaduresActivity.class);
        intent.putExtra("idusuari", idusuari);
        intent.putExtra("nom", nomadmin);

        startActivityForResult(intent, TEXT_REQUEST);
    }

    public void jugadentra(View view) {
        Intent intent = new Intent(this, JugadorsActivity.class);

        intent.putExtra("idusuari", idusuari);
        intent.putExtra("nom", nomadmin);

        startActivityForResult(intent, TEXT_REQUEST);
    }

    public void botoadmin(View view) {
        Intent intent = new Intent(this, AdminActivity.class);

        intent.putExtra("idusuari", idusuari);
        intent.putExtra("nom", nomadmin);

        startActivityForResult(intent, TEXT_REQUEST);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {

        getMenuInflater().inflate(R.menu.menu1, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        //serveix per les diferents opcions del menu
        int id = item.getItemId();

        String adresa = "pere_terradasanfrons@iescarlesvallbona.cat,  manel_soromontalvez@iescarlesvallbona.cat";

        if (id == R.id.escr) {
            FerEmail(adresa);
            return true;
        }
        if (id == R.id.ajuda) {
            Ajuda();
            return true;
        }
        if(id ==R.id.main){
            Tanca();
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    public void FerEmail(String addresses) {
        Intent intent = new Intent(Intent.ACTION_SEND);
        intent.setType("*/*");
        intent.putExtra(Intent.EXTRA_EMAIL, addresses);
        if (intent.resolveActivity(getPackageManager()) != null) {
            startActivity(intent);
        }
    }

    public void Ajuda() {
        Intent intent = new Intent(this, QuisomActivity.class);

        intent.putExtra("idusuari", idusuari);
        intent.putExtra("nom", nomadmin);

        startActivityForResult(intent, TEXT_REQUEST);
    }
    public void Tanca(){
        Intent intent = new Intent(this, MainActivity.class);

        startActivity(intent);
    }
}
