const { graphql, buildSchema } = require('graphql');

// Definición del esquema
const schema = buildSchema(`
  type Query {
    getUser(id: ID): User
  }

  type User {
    id: ID
    username: String
  }
`);

// Resolvers
const root = {
  getUser: ({ id }) => {
    // Lógica para obtener un usuario por ID
    return { id, username: 'ejemploUsuario' };
  },
};

// Ejecución de la consulta con parámetros
graphql(schema, '{ getUser(id: "123") { id, username } }', root).then((response) => {
  console.log(response);
});