import * as React from "react";
import { Edit, SimpleForm, EditProps, TextInput } from "react-admin";

export const AdminEdit = (props: EditProps): React.ReactElement => {
  return (
    <Edit {...props}>
      <SimpleForm>
        <TextInput label="email" source="email" type="email" />
        <div />
        <TextInput label="name" source="name" />
        <TextInput label="password" source="password" />
      </SimpleForm>
    </Edit>
  );
};
