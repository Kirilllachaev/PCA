package mirea.pca;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
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
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.rengwuxian.materialedittext.MaterialEditText;

import Models.User;

public class MainActivity extends AppCompatActivity {
    private EditText logField,pasField;
    private FirebaseAuth auth;
    private DatabaseReference mDataBase;
    private String GET_KEY="USER";
    private ConstraintLayout root;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main_window);
        init();
    }
    private void init(){
        root=findViewById(R.id.root_element);
        logField=findViewById(R.id.logField);
        pasField=findViewById(R.id.pasField);
        mDataBase=FirebaseDatabase.getInstance().getReference(GET_KEY);
        auth=FirebaseAuth.getInstance();
    }
    public void OnClickSave(View view)
    {
        String log=logField.getText().toString();
        String id=log;
        String pas=pasField.getText().toString();if (TextUtils.isEmpty(logField.getText().toString())) {
                Snackbar.make(root, "Введите ваш логин", Snackbar.LENGTH_SHORT).show();
                return;
            }
            if (pasField.getText().toString().length() < 7) {
                Snackbar.make(root, "Введите пароль длиннее 7-ми символов", Snackbar.LENGTH_SHORT).show();
                return;
            }
        User newUser=new User(log,pas,id);
        mDataBase.child("/"+ log).setValue(newUser)
        .addOnSuccessListener(aVoid -> Snackbar.make(root,"Пользователь добавлен",Snackbar.LENGTH_SHORT).show());
    }
    public void SingInClick(View view)
    {
        String log=logField.getText().toString();
        String pas=pasField.getText().toString();
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
                        finish();
                    }).addOnFailureListener(e -> Snackbar.make(root,"Ошибка авторизации " + e.getMessage(),Snackbar.LENGTH_SHORT).show());
        }
    }



//            if (TextUtils.isEmpty(log.getText().toString())) {
//                Snackbar.make(root, "Введите ваш логин", Snackbar.LENGTH_SHORT).show();
//                return;
//            }
//            if (pas.getText().toString().length() < 7) {
//                Snackbar.make(root, "Введите пароль длиннее 7-ми символов", Snackbar.LENGTH_SHORT).show();
//                return;
//            }
//            auth.signInWithEmailAndPassword(log.getText().toString(),pas.getText().toString())
//                    .addOnSuccessListener(authResult -> {
//                        startActivity(new Intent(MainActivity.this,PekiActivity.class));
//                        finish();
//                    }).addOnFailureListener(e -> Snackbar.make(root,"Ошибка авторизации" + e.getMessage(),Snackbar.LENGTH_SHORT).show());
//        });
//    }
//
//    private void SendNudes() {
//        LayoutInflater inflater = LayoutInflater.from(this);
//        View main_window = inflater.inflate(R.layout.main_window, null);
//        final MaterialEditText log = main_window.findViewById(R.id.logField);
//        final MaterialEditText pas = main_window.findViewById(R.id.pasField);
//        btnReg.setOnClickListener(v -> {
//            if (TextUtils.isEmpty(log.getText().toString())) {
//                Snackbar.make(root, "Введите ваш логин", Snackbar.LENGTH_SHORT).show();
//                return;
//            }
//            if (pas.getText().toString().length() < 7) {
//                Snackbar.make(root, "Введите пароль длиннее 7-ми символов", Snackbar.LENGTH_SHORT).show();
//                return;
//            }
//            auth.createUserWithEmailAndPassword(log.getText().toString(),pas.getText().toString())
//                .addOnSuccessListener(authResult -> {
//                    User user = new User();
//                    user.setLog(log.getText().toString());
//                    user.setPas(pas.getText().toString());
//
//                    users.child(FirebaseAuth.getInstance().getCurrentUser().getUid())
//                            .setValue(user)
//                            .addOnSuccessListener(aVoid -> Snackbar.make(root,"Пользователь добавлен",Snackbar.LENGTH_SHORT).show());
//                });
//        });
//    }
//}
