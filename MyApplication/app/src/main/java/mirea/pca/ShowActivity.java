package mirea.pca;

import android.content.Intent;
import android.os.Bundle;
import android.os.PersistableBundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import org.w3c.dom.Text;

import java.util.ArrayList;
import java.util.List;

import Models.User;

public class ShowActivity extends AppCompatActivity {
    private ArrayAdapter<String> adapter_2;
    private List<String> listData_2;
    private DatabaseReference mDataBase;
    private String GET_KEY = "Users";
    private String n;    public ListView listView_2;


    @Override
    public void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.show_layout);
        init();
        getData();
        getIntentMain();
    }

    private void init() {
        listView_2 = findViewById(R.id.listView_2);
        listData_2 = new ArrayList<>();
        adapter_2 = new CustomListAdapter(this , R.layout.custom_list , listData_2);
        listView_2.setAdapter( adapter_2);
//        adapter_2 = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, listData_2);
//        listView_2.setAdapter(adapter_2);
        mDataBase = FirebaseDatabase.getInstance().getReference(GET_KEY);
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

                if(listData_2.size() > 0)listData_2.clear();
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

                                    if(n.contains(Imya))
                                    {
                                        for(DataSnapshot ds4: ds3.getChildren())
                                        {
                                            String Imya_2 = ds4.getKey();
                                            String St = "Story";
                                            if(St.contains((Imya_2)))
                                            {
                                                for(DataSnapshot ds5: ds4.getChildren())
                                                {
                                                    String Imya_3 = ds5.getKey();
                                                    Imya_3 += ds5.getValue(Object.class).toString();
                                                    listData_2.add(Imya_3);
                                                }
                                            }

                                        }

                                    }
                                }

                            }
                        }

                    }

                }

                adapter_2.notifyDataSetChanged();
            }
            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {
            }
        };
        mDataBase.addValueEventListener(vListener);
    }

    private void getIntentMain() {
        Intent i = getIntent();
        n=i.getStringExtra("key");
    }
}
