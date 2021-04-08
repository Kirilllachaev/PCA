package mirea.pca;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;

import com.google.firebase.FirebaseApp;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

import Models.User;

public class PekiActivity extends AppCompatActivity {
    private TextView TextName;
    private ListView listView;
    private ArrayAdapter<String> adapter;
    private List<String> listData;
    private DatabaseReference mDataBase;
    private FirebaseAuth auth;
    public final String log_key="log_key";
    public SharedPreferences pref;
    private String GET_KEY="Users";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_peki);
        init();
        getData();
        SetOnClickItem();
    }
    private void init(){
        pref=getSharedPreferences("Login",MODE_PRIVATE);
        TextName = findViewById(R.id.TextName);
        TextName.setText(pref.getString(log_key,""));
        listView=findViewById(R.id.listView);
        listData=new ArrayList<>();
        adapter = new CustomListAdapter(this , R.layout.custom_list , listData);
        listView.setAdapter( adapter);
        mDataBase= FirebaseDatabase.getInstance().getReference(GET_KEY);
        auth=FirebaseAuth.getInstance();
    }
    private void getData()
    {
        ValueEventListener vListener=new ValueEventListener()
        {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot)
            {

                FirebaseUser g = FirebaseAuth.getInstance().getCurrentUser();
                String ID =  g.getUid();

                if(listData.size() > 0)listData.clear();
                for(DataSnapshot ds: dataSnapshot.getChildren())
                {
                    String user = ds.getKey();
                    assert user != null;

                    if(user.contains(ID))
                    {
                        for(DataSnapshot ds2: ds.getChildren())
                        {
                            String desktops = ds2.getKey();
                            String Naz = "Desktops";

                            if(Naz.contains(desktops))
                            {
                                for(DataSnapshot ds3: ds2.getChildren())
                                {
                                    String Imya = ds3.getKey();
                                    listData.add(Imya);
                                }

                            }
                        }

                    }

                }

                adapter.notifyDataSetChanged();
            }
            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {
            }
        };
        mDataBase.addValueEventListener(vListener);
    }

    private void SetOnClickItem()
    {
        listView.setOnItemClickListener((parent, view, position, id) ->
        {
//            TextView textView = (TextView) view.findViewById(R.id.list_content);
//            String text = textView.getText().toString();
//            System.out.println("Choosen Country = : " + text);
            String user = listData.get(position);
            Intent i = new Intent(PekiActivity.this,ShowActivity.class);
            i.putExtra("key", user);
            startActivity(i);

        });
    }
public void SignOut(View view)
{
    auth.signOut();
    startActivity(new Intent(PekiActivity.this,MainActivity.class));
}
}