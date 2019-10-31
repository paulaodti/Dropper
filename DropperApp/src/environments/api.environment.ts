export const apiPaths = {
  medicao_valor: {
    getAll: 'Vazao',
    get: function(id) {
      return `Vazao/${id}`;
    }
  },
  medidor_vazao: {
    getAll: 'Sensor',
    edit: function(id) {
      return `Sensor/${id}`;
    },
    delete: function(id) {
      return `Sensor/${id}`;
    }
  }
};
