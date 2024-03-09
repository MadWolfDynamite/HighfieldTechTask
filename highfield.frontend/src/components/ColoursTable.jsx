import PropTypes from 'prop-types';

const ColoursTable = ({ colours }) => {
  return (
      <table>
          <thead>
              <th></th>
              <th>Total Users</th>
          </thead>

          <tbody>
              {
                  colours.map((c) => (
                      <tr key={c.colour}>
                          <td>{c.colour}</td>
                          <td>{c.count}</td>
                      </tr>
                  ))
              }
          </tbody>
      </table>
  );
}
ColoursTable.propTypes = {
    colours: PropTypes.arrayOf(PropTypes.object)
};

export default ColoursTable;