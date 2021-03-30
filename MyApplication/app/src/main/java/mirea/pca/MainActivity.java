package mirea.pca;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.os.Environment;
import android.text.TextUtils;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.google.android.gms.tasks.OnFailureListener;
import com.google.android.gms.tasks.OnSuccessListener;
import com.google.android.material.snackbar.Snackbar;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.rengwuxian.materialedittext.MaterialEditText;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.io.OutputStreamWriter;

import Models.User;

public class MainActivity extends AppCompatActivity {
//    private final String log_key="log_key";
//    private SharedPreferences pref;
    private EditText logField,pasField;
    private FirebaseAuth auth;
    private DatabaseReference mDataBase;
    private String GET_KEY="Users/";
    private ConstraintLayout root;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main_window);
//        FirebaseUser user = FirebaseAuth.getInstance().getCurrentUser();
//        if (user != null) {
//            startActivity(new Intent(MainActivity.this,PekiActivity.class));
//        } else {
//            setContentView(R.layout.main_window);
//        }

    }
    private void init(){

//        pref=getSharedPreferences("Login",MODE_PRIVATE);
        root=findViewById(R.id.root_element);
        logField=findViewById(R.id.logField);
        pasField=findViewById(R.id.pasField);
        mDataBase=FirebaseDatabase.getInstance().getReference(GET_KEY);
        auth=FirebaseAuth.getInstance();
    }
    public void OnClickSave(View view)
    {
        if (TextUtils.isEmpty(logField.getText().toString())) {
                Snackbar.make(root, "Введите ваш логин", Snackbar.LENGTH_SHORT).show();
                return;
            }
            if (pasField.getText().toString().length() < 7) {
                Snackbar.make(root, "Введите пароль длиннее 7-ми символов", Snackbar.LENGTH_SHORT).show();
                return;
            }
        auth.createUserWithEmailAndPassword(logField.getText().toString(),pasField.getText().toString())
                .addOnSuccessListener(authResult -> {
                    User user = new User();
                    user.login=(logField.getText().toString());
                    user.pass=(pasField.getText().toString());

                    mDataBase.child(FirebaseAuth.getInstance().getCurrentUser().getUid())
                            .setValue(user)
                            .addOnSuccessListener(aVoid -> Snackbar.make(root,"Пользователь добавлен",Snackbar.LENGTH_SHORT).show());
                });
    }
    public void SingInClick(View view)
    {
        if (TextUtils.isEmpty(logField.getText().toString())) {
                Snackbar.make(root, "Введите ваш логин", Snackbar.LENGTH_SHORT).show();
                return;
            }
            if (pasField.getText().toString().length() < 7) {
                Snackbar.make(root, "Введите пароль длиннее 7-ми символов", Snackbar.LENGTH_SHORT).show();
                return;
            }
                    auth.signInWithEmailAndPassword(logField.getText().toString(),pasField.getText().toString())
                    .addOnSuccessListener(authResult -> {
                        startActivity(new Intent(MainActivity.this,PekiActivity.class));
//                        SaveLog();
                        finish();
                    }).addOnFailureListener(e -> Snackbar.make(root,"Ошибка авторизации " + e.getMessage(),Snackbar.LENGTH_SHORT).show());
        }
//        public void SaveLog()
//        {
//            SharedPreferences.Editor edit = pref.edit();
//            edit.putString(log_key,logField.getText().toString());
//            edit.apply();
//        }
//        public void SetLog()
//        {
//            if(pref.getString(log_key,null) = auth.getCurrentUser();
//            {
//                startActivity(new Intent(MainActivity.this, PekiActivity.class));
//            }
//        }
    }


