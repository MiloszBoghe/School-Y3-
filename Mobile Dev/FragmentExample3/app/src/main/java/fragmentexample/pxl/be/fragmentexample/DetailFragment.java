package fragmentexample.pxl.be.fragmentexample;

import android.app.Fragment;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;

public class DetailFragment extends Fragment {

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.activity_detail_fragment, container, false);

        Bundle bundle = getArguments();
        EditText editText = (EditText) view.findViewById(R.id.editTextItem);
        String item = "";

        if(bundle != null){
            item = getArguments().getString("item");
        }

        editText.setText(item);

        return view;
    }

}
